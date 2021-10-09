using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Unity.Precompiler.Source;

namespace Unity.Precompiler
{
    public partial class UnityPrecompiler
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // Initialize generator
            context.RegisterForSyntaxNotifications(() => new PrecompilerReceiver());
            context.RegisterForPostInitialization((context) => context.Emit());
        }
    }
}