using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Precompiler.Generator.Tests;

namespace Receiver.UnitTests
{
    public partial class UnityReceiverTests
    {
        #region Test Code

        const string ExpectedResolutions = "// Resolutions = 1, Declarations = 1, Registrations = 0";
        const string Unity_Resolve_TestCode = StringConstants.TestNamespaces + @"

namespace Unity.Precompiler.Tests
{
    public class UnityTestsClass
    {
        public void CreateContainer()
        { 
            var container = new UnityContainer();

            var instance = container.<!--declaration-->;
        }
    }
}";
        #endregion


        [Ignore]
        [TestMethod, DynamicData(nameof(Resolve_TestData))]
        [TestProperty(StringConstants.TestingConst, StringConstants.RegisterTypeConst)]
        public async Task Unity_Resolve(string declaration)
        {
            // Arrange
            verifyCS.TestCode = StringConstants.DeclarationRegex
                                               .Replace(Unity_Resolve_TestCode, declaration);

            // Verify
            await verifyCS.GeneratedSource(ExpectedResolutions)
                          .RunAsync();
        }


        #region Test Data

        public static IEnumerable<object[]> Resolve_TestData
        {
            get
            {
                yield return new object[] { "Resolve<object>()" };
            }
        }

        #endregion
    }
}
