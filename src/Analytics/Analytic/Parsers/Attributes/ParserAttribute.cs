using Microsoft.CodeAnalysis;
using System;
using System.Text.RegularExpressions;

namespace Unity.Precompiler.Analysis
{
    /// <summary>
    /// This attribute marks parser methods of type <see cref="OperationParser"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ParserAttribute : Attribute
    {
        #region Constructors

        public ParserAttribute(OperationKind kind)
        {
            Kind = kind;
        }

        public ParserAttribute(OperationKind kind, string name)
        {
            Kind = kind;
            Name = name;
        }

        #endregion

        
        #region Properties

        public OperationKind Kind { get; }

        public string? Name { get; }

        public Regex? Version {  get; set; }

        #endregion
    }
}
