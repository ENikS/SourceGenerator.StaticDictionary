using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Precompiler.Visitors
{
    public partial class VisitorSet<TVisitor>
        where TVisitor : IOperation
    {

        #region  API

        public static VisitorSet<TVisitor>? Create(OperationKind kind, IEnumerable<AssemblyName> references)
        { 
            throw new NotImplementedException();
        }

        internal Func<TVisitor, IEnumerable<Diagnostic>>? Get(string name, string assembly)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
