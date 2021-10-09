using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Unity.Precompiler.Tests;
using VerifyCS = Unity.Analytics.Test.CSharpAnalyzerVerifier<Unity.Precompiler.Analytics.PrecompilerAnalyzer>;

namespace Invocation.Tests
{
    public partial class ResolveTests
    {
        [TestMethod, DynamicData(nameof(IUnityContainer_TestData))]
        [TestProperty(StringConstants.TestingConst, StringConstants.RegisterTypeConst)]
        public async Task OnUnityContainer(string declaration)
        {
            // Arrange
            var test = StringConstants.DeclarationRegex.Replace(StringConstants.TestNamespaces + @"
            namespace Unity.Precompiler.Tests
            {
                public class UnityTestsClass
                {
                    public void CreateContainer()
                    { 
                        UnityContainer container = new UnityContainer();

                        container.<!--declaration-->;
                    }
                }
            }", declaration);

            // Verify     
            await VerifyCS.VerifyAnalyzerAsync(test);
        }

        [TestMethod, DynamicData(nameof(IUnityContainer_TestData))]
        [TestProperty(StringConstants.TestingConst, StringConstants.RegisterTypeConst)]
        public async Task OnIUnityContainer(string declaration)
        {
            // Arrange
            var test = StringConstants.DeclarationRegex.Replace(StringConstants.TestNamespaces + @"
            namespace Unity.Precompiler.Tests
            {
                public class UnityTestsClass
                {
                    public void CreateContainer()
                    { 
                        IUnityContainer container = new UnityContainer();

                        container.<!--declaration-->;
                    }
                }
            }", declaration);

            // Verify     
            await VerifyCS.VerifyAnalyzerAsync(test);
        }
    }
}
