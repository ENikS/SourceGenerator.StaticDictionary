using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
using System.Reflection;
using CSharp = Microsoft.CodeAnalysis.CSharp;
using VisualBasic = Microsoft.CodeAnalysis.VisualBasic;

namespace Unity.Precompiler
{
    [ParserFactory]
    public partial class PrecompilerReceiver : ISyntaxContextReceiver
    {
        #region Properties

        public AssemblyName? UnityInfo { get; set; }

        #endregion


        #region ISyntaxContextReceiver

        public virtual void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            switch (context.Node.RawKind)
            {
                case (int)CSharp.SyntaxKind.CompilationUnit:
                case (int)VisualBasic.SyntaxKind.CompilationUnit:
                    OnCompilationUnit(context.SemanticModel.Compilation);
                    break;

                case (int)CSharp.SyntaxKind.InvocationExpression:
                case (int)VisualBasic.SyntaxKind.InvocationExpression:
                    //OnInvocationOperation((IInvocationOperation?)
                    //    context.SemanticModel.GetOperation(context.Node));
                    break;
            }
        }

        #endregion


        #region Implementation

        private void OnCompilationUnit(Compilation compilation)
        {
            //UnityInfo = compilation.UnityAssemblyName();
        }

        private void OnInvocationOperation(IInvocationOperation? operation)
        {
            if (operation is null) return;

            //var method = operation.TargetMethod.OriginalDefinition.ToString();
            //foreach (OperationParser parser in OperationParsers.Get(OperationKind.Invocation, method))
            //    parser.Invoke(this, operation);


            return;
        }

        #endregion
    }
}
