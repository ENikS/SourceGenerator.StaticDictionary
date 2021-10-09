using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Unity.Precompiler;
using Unity.Precompiler.Generator.Tests;
using VerifyCS = Generator.UnitTests
    .CSharpSourceGeneratorTest<Receiver.UnitTests.SpyGenerator>;

namespace Receiver.UnitTests
{
    [TestClass]
    public partial class UnityReceiverTests
    {
        #region Fields

        protected VerifyCS verifyCS;

        #endregion


        #region Initialization

        static UnityReceiverTests()
        {
            //OperationParsers.Initialize(typeof(PrecompilerReceiver).Assembly);
        }


        [TestInitialize]
        public void InitializeTest()
        {
            verifyCS = new VerifyCS();
        }


        #endregion


        #region Tests

        [TestMethod, TestProperty(StringConstants.TestingConst, nameof(Baseline))]
        public async Task Baseline()
            => await verifyCS.GeneratedSource(SpyGenerator.Empty)
                             .RunAsync();

        #endregion
    }


    #region Generator

    public sealed class SpyGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var receiver = (PrecompilerReceiver)context.SyntaxContextReceiver;

            var sb = new StringBuilder("// ");

            sb.Append($"Resolutions = {receiver.Resolutions.Count}, ");
            sb.Append($"Declarations = {receiver.Declarations.Count}, ");
            sb.Append($"Registrations = {receiver.Registrations.Count}");

            context.AddSource("file.cs", sb.ToString());
        }

        public void Initialize(GeneratorInitializationContext context) 
            => context.RegisterForSyntaxNotifications(() => new PrecompilerReceiver());

        public static string Empty => "// Resolutions = 0, Declarations = 0, Registrations = 0";
    }

    #endregion
}
