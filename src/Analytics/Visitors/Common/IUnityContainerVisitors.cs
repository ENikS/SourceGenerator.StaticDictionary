using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;
using System.Linq;
using Unity.Precompiler;

namespace Unity.Common.Visitors
{
    [VisitorFactory("Unity.Abstractions")]
    public static class IUnityContainerVisitors
    {
        [InvocationVisitor(name: "Microsoft.Practices.Unity.IUnityContainer.Resolve(System.Type, string, params Microsoft.Practices.Unity.ResolverOverride[])",
                       assembly: "Microsoft.Practices.Unity")]

        [InvocationVisitor(name: "Unity.IUnityContainer.Resolve(System.Type, string, params Unity.Resolution.ResolverOverride[])",
                       assembly: "Unity.Abstractions")]
        public static IEnumerable<Diagnostic> Resolve_Type_string_ResolverOverride(IInvocationOperation operation)
        {
            return Enumerable.Empty<Diagnostic>();
        }
    }
}
