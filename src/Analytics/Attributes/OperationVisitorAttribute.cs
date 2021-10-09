using Microsoft.CodeAnalysis;
using System;

namespace Unity.Precompiler
{
    /// <summary>
    /// This attribute marks parser methods of type <see cref="OperationParser"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class OperationVisitorAttribute : Attribute
    {
        #region Constructors

        public OperationVisitorAttribute(OperationKind kind, string name, string? assembly = null)
        {
            Kind = kind;
            Name = name;
            Assembly = assembly;
        }

        #endregion

        
        #region Properties

        public OperationKind Kind { get; }

        public string? Name { get; }

        public string? Assembly { get; }

        #endregion
    }
}
