using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Unity.Precompiler.Generator.Tests;

namespace Receiver.UnitTests
{
    public partial class UnityReceiverTests
    {
        #region Test Code

        const string Unity_RegisterPartial_TestCode = StringConstants.TestNamespaces + @"

namespace Unity.Precompiler.Tests
{
    public class UnityTestsClass
    {
        public void CreateContainer()
        { 
            var container = new UnityContainer();

            container.<!--declaration-->;
        }
    }

    public class OtherTestsClass
    {
        public void Xyz()
        { 
        }
    }
}";

        #endregion

        [TestMethod, DynamicData(nameof(UnityContainer_RegisterType_TestData))]
        [TestProperty(StringConstants.TestingConst, StringConstants.RegisterTypeConst)]
        public async Task Unity_RegisterPartial(string declaration)
        {
            // Arrange
            verifyCS.TestCode = StringConstants.DeclarationRegex
                                               .Replace(Unity_RegisterPartial_TestCode, declaration);

            // Verify
            await verifyCS.GeneratedSource(ExpectedRegistrations)
                          .RunAsync();
        }
    }
}
