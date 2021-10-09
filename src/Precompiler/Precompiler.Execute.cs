using Microsoft.CodeAnalysis;
using Unity.Precompiler.Source;

namespace Unity.Precompiler
{
    public partial class UnityPrecompiler
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var receiver = (PrecompilerReceiver?)context.SyntaxContextReceiver;
            if (receiver is null || receiver.UnityInfo == null) return;

            // Emit extension code
            context.Emit(receiver.UnityInfo);





            //var name = Path.GetFileName(syntaxTrees.First().FilePath);
            // inject the created source into the users compilation
            //context.AddSource(name, SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));
        }
    }
}
