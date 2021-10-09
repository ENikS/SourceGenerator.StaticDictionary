using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Unity.Precompiler;
using Unity.Precompiler.Generator.Tests;
using VerifyCS = Generator.UnitTests.CSharpSourceGeneratorTest<Unity.Precompiler.UnityPrecompiler>;

namespace Generator.UnitTests
{
    [TestClass]
    public partial class UnityPrecompilerTests
    {
        #region Fields

        protected VerifyCS VerifyCS;
#if UNITY_V4
        protected static string version = "4";
#elif UNITY_V5
        protected static string version = "5";
#elif UNITY_V6
        protected static string version = "6";
#else
        protected static string version = "Invalid";
#endif
        protected static SourceText commonCode;
        protected static SourceText versionedCode;

        #endregion


        static UnityPrecompilerTests()
        {
            var assembly = typeof(UnityPrecompiler).Assembly;
            using (Stream stream = assembly.GetManifestResourceStream(assembly
                .GetManifestResourceNames().First(name => name.EndsWith(".Templates.Precompiled.cs"))))
            {
                using StreamReader reader = new(stream);
                commonCode = SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
            }

            using (Stream stream = assembly.GetManifestResourceStream(assembly
                .GetManifestResourceNames().First(name => name.EndsWith($".Templates.Extension.Precompiled.v{version}.cs"))))
            {
                using StreamReader reader = new(stream);
                versionedCode = SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
            }
        }


        #region Initialization

        [TestInitialize]
        public void InitializeTest()
        {
            VerifyCS = new VerifyCS
            { 
                TestState = 
                { 
                    GeneratedSources = 
                    {
                        (typeof(UnityPrecompiler),  "Unity.Precompiled.Generated.cs", commonCode),
                        (typeof(UnityPrecompiler), $"Unity.Precompiled.Generated.v{version}.cs", versionedCode)
                    }
                }
            };
        }

        #endregion


        #region Tests

        [TestMethod, TestProperty(StringConstants.TestingConst, nameof(Baseline))]
        public async Task Baseline()
            => await VerifyCS.RunAsync();

        #endregion
    }
}
