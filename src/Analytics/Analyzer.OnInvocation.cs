using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using System;

namespace Unity.Precompiler.Analytics
{
    // Avoid storing per-compilation data into the fields of a diagnostic analyzer
    #pragma warning disable RS1008 

    public partial class PrecompilerAnalyzer : DiagnosticAnalyzer
    {
        #region Fields


        #endregion

        private void OnInvocationOperation(OperationAnalysisContext context)
        {

        }
    }
    
    #pragma warning restore RS1008
}
