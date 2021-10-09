using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Unity.Precompiler.Visitors
{
    public partial class VisitorSet<TVisitor>
    {
        static VisitorSet()
        {
            _data = new[]
            {
                new Entry
                {

                }
            };
        }
    }
}
