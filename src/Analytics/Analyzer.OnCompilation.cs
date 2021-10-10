using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Unity.Precompiler.Analytics
{
    public partial class PrecompilerAnalyzer : DiagnosticAnalyzer
    {
        private void OnCompilationBase(SyntaxNodeAnalysisContext context)
        {
        }
    }
}
