using Microsoft.CodeAnalysis;

namespace Unity.Precompiler.Analysis
{
    public static partial class UnityV4
    {
        [Parser(OperationKind.Invocation,
            "Unity.")]
        public static AnalyticModel? Register(IOperation operation)
        {
            return null;
        }

    }
}
