using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public class DeclarationModel : AnalyticModel
    {
        public DeclarationModel(IOperation operation)
            : base(operation)
        {
        }

        //public INamedTypeSymbol NamedTypeSymbol => (INamedTypeSymbol)Symbol;
    }
}
