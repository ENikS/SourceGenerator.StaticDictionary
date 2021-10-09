using Microsoft.CodeAnalysis;
using System;
using System.Text.RegularExpressions;

namespace Unity.Precompiler
{
    /// <summary>
    /// This attribute marks parser methods of type <see cref="OperationParser"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class VisitorFactoryAttribute : Attribute
    {
        #region Constructors

        public VisitorFactoryAttribute(string assembly)
        {
            Assembly = assembly;
        }

        #endregion

        
        #region Properties

        public string? Assembly { get; }

        public Regex? Version {  get; set; }

        #endregion
    }
}
