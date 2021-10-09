using Microsoft.CodeAnalysis;
using System;

namespace Unity.Precompiler
{
    /// <summary>
    /// This attribute marks parser methods of type <see cref="OperationParser"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class InvocationVisitorAttribute : OperationVisitorAttribute
    {
        #region Constructors

        public InvocationVisitorAttribute(string name, string? assembly = null)
            : base(OperationKind.Invocation, name, assembly)
        {
        }

        #endregion
    }
}
