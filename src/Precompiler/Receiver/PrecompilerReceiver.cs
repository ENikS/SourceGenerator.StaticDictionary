using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;

namespace Unity.Precompiler
{
    public partial class PrecompilerReceiver
    {
        #region Fields

        private readonly IList<ClassDeclarationSyntax> _declarations = new List<ClassDeclarationSyntax>();
        private IList<InvocationExpressionSyntax>? _resolutions;
        private IList<InvocationExpressionSyntax>? _registrations;

        #endregion


        #region Implementation

        public IList<ClassDeclarationSyntax> Declarations => _declarations;
        public IList<InvocationExpressionSyntax> Resolutions => _resolutions ??= new List<InvocationExpressionSyntax>();

        public IList<InvocationExpressionSyntax> Registrations => _registrations ??= new List<InvocationExpressionSyntax>();

        #endregion
    }
}
