﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Immutable;

namespace Generator.UnitTests
{
    public class CSharpSourceGeneratorTest<TSourceGenerator> : SourceGeneratorTest<TSourceGenerator>
        where TSourceGenerator : ISourceGenerator, new()
    {
        public override string Language => LanguageNames.CSharp;

        protected override string DefaultFileExt => "cs";

        protected override GeneratorDriver CreateGeneratorDriver(Project project, ImmutableArray<ISourceGenerator> sourceGenerators) 
            => CSharpGeneratorDriver.Create(
                sourceGenerators,
                project.AnalyzerOptions.AdditionalFiles,
                (CSharpParseOptions)project.ParseOptions!,
                project.AnalyzerOptions.AnalyzerConfigOptionsProvider);

        protected override CompilationOptions CreateCompilationOptions() 
            => new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

        protected override ParseOptions CreateParseOptions() 
            => new CSharpParseOptions(LanguageVersion.Default, DocumentationMode.Diagnose);
    }
}
