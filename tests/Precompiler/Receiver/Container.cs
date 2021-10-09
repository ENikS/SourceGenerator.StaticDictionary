using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Precompiler.Generator.Tests;

namespace Receiver.UnitTests
{
    public partial class UnityReceiverTests
    {
        #region Test Code

        const string ExpectedRegistrations = "// Resolutions = 0, Declarations = 1, Registrations = 1";
        const string UnityContainer_RegisterType_TestCode = StringConstants.TestNamespaces + @"

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
}";
        #endregion

        [TestMethod, DynamicData(nameof(UnityContainer_RegisterType_TestData))]
        [TestProperty(StringConstants.TestingConst, StringConstants.RegisterTypeConst)]
        public async Task UnityContainer_RegisterType(string declaration)
        {
            // Arrange
            verifyCS.TestCode = StringConstants.DeclarationRegex
                                               .Replace(UnityContainer_RegisterType_TestCode, declaration);

            // Verify
            await verifyCS.GeneratedSource(ExpectedRegistrations)
                          .RunAsync();
        }


        #region Test Data

        public static IEnumerable<object[]> UnityContainer_RegisterType_TestData
        {
            get
            {
                //IUnityContainer.RegisterType(Type? contractType, Type implementationType, string? contractName, ITypeLifetimeManager? lifetimeManager, params InjectionMember[] injectionMembers)
                yield return new object[] { "RegisterType((Type)null, typeof(object), (string)null, null, null)" };

                yield return new object[] { "RegisterType<object>()" };
            }
        }

        #endregion
    }
}
