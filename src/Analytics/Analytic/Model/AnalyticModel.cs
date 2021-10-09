using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public abstract class AnalyticModel
    {
        protected AnalyticModel(IOperation operation)
        {
            Syntax = operation.Syntax;
        }

        public SyntaxNode Syntax { get; }
    }
}
