using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyCS = Unity.Analytics.Test.CSharpAnalyzerVerifier<Unity.Precompiler.Analytics.PrecompilerAnalyzer>;

namespace Invocation.Tests
{
    [TestClass]
    public partial class NoContainerTests
    {
        [TestMethod]
        public async Task OnUnityContainer(string declaration)
        {
            // Arrange
            var test = @"
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;

            namespace Unity.Precompiler.Tests
            {
                public class UnityTestsClass
                {
                    public void NoContainer()
                    { 
                    }
                }
            }";

            // Verify     
            await VerifyCS.VerifyAnalyzerAsync(test);
        }

    }
}
