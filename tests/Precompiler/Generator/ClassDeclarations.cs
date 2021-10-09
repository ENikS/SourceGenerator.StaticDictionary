using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Unity.Precompiler.Generator.Tests;

namespace Generator.UnitTests
{
    public partial class UnityPrecompilerTests
    {
        [TestMethod]
        [TestProperty(StringConstants.TestingConst, StringConstants.Declarations)]
        public async Task SingleCleassDeclaration()
        {
            // Arrange
            VerifyCS.TestCode = StringConstants.TestNamespaces +
                @"namespace Unity.Precompiler.Tests { public class PrecompilerTestClass { } }"; 

            // Verify
            await VerifyCS.RunAsync();
        }

        [TestMethod]
        [TestProperty(StringConstants.TestingConst, StringConstants.Declarations)]
        public async Task PartialCleassDeclaration()
        {
            // Arrange
            VerifyCS.TestState.Sources.Add(StringConstants.TestNamespaces + @"
namespace Unity.Precompiler.Tests 
{ 
    public partial class PartialTestClass 
    { 
        /*first*/ 
    } 
}");

            VerifyCS.TestState.Sources.Add(StringConstants.TestNamespaces + @"
namespace Unity.Precompiler.Tests 
{
    public partial class PartialTestClass
    {
        /*second*/
    }
}");

            // Verify
            await VerifyCS.RunAsync();
        }
    }
}
