using Microsoft.CodeAnalysis;

namespace Unity.Precompiler
{
    [Generator]
    public partial class UnityPrecompiler : ISourceGenerator
    {
        #region Constructors

        static UnityPrecompiler()
        {
            // Register Visitors
            //OperationParsers.Initialize(//typeof(SyntaxReceiver).Assembly, 
            //                          typeof(UnityPrecompiler).Assembly);
        }

        #endregion
    }
}
