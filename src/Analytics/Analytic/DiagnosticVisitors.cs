using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace Unity.Precompiler.Analytics
{
    //[Export(typeof(Func<IOperation, IEnumerable<Diagnostic>>))]
    public static class DiagnosticVisitors
    {
        //[ExportMetadata(nameof(Visitors.Entry.Version), @"^(4\.)?([1-3]\.)?(\*|\d+)$")]
        //[ExportMetadata(nameof(Visitors.Entry.Assembly), "Unity.IUnityContainer")]
        //[Export("Unity.IUnityContainer.Resolve(System.Type, string, params Unity.Resolution.ResolverOverride[])", typeof(IInvocationOperation))]
        public static IEnumerable<Diagnostic> ValidateOperation(IOperation operation)
        {
            return Enumerable.Empty<Diagnostic>();
        }
    }
}
