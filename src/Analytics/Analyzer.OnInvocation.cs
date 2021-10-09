using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using System;
using Unity.Precompiler.Visitors;

namespace Unity.Precompiler.Analytics
{
    // Avoid storing per-compilation data into the fields of a diagnostic analyzer
    #pragma warning disable RS1008 

    public partial class PrecompilerAnalyzer : DiagnosticAnalyzer
    {
        #region Fields

        private VisitorSet<IInvocationOperation>? _visitors;

        #endregion

        private void OnInvocationOperation(OperationAnalysisContext context)
        {
            if (_visitors is null) return;
#if DEBUG
            if (context.Operation.Kind is not OperationKind.Invocation) 
                throw new InvalidOperationException();
#endif
            var operation = (IInvocationOperation)context.Operation;
            var name = operation.TargetMethod.OriginalDefinition.ToString();
            var assembly = operation.TargetMethod.OriginalDefinition.ContainingAssembly.Name;

            var parser = _visitors.Get(name, assembly);
            if (parser is null) return;

            var model = parser.Invoke(operation);
            if (model is null) return;


            //// Find just those named type symbols with names containing lowercase letters.
            //if (namedTypeSymbol.Name.ToCharArray().Any(char.IsLower))
            //{
            //    // For all such symbols, produce a diagnostic.
            //    var diagnostic = Diagnostic.Create(Rule, namedTypeSymbol.Locations[0], namedTypeSymbol.Name);

            //    context.ReportDiagnostic(diagnostic);
            //}

        }
    }
    
    #pragma warning restore RS1008
}
