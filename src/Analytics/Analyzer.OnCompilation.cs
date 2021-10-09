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
        private static Regex _regex = 
            new Regex(@"Unity\.Container\.dll|Unity\.Abstractions\.dll|Microsoft\.Practices\.Unity\.dll", 
                      RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private void OnCompilationBase(SyntaxNodeAnalysisContext context)
        {
            var references = context.Compilation
                                    .References
                                    .OfType<PortableExecutableReference>()
                                    .Where(assembly => _regex.IsMatch(assembly.Display))
                                    .Select(assembly => AssemblyName.GetAssemblyName(assembly.FilePath));

            _visitors = VisitorSet<IInvocationOperation>.Create(OperationKind.Invocation, references);
        }
    }
}
