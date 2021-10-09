using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Unity.Precompiler.Generator.Tests;
#if UNITY_V4
using Microsoft.Practices.Unity;
#else
using Unity;
#endif

namespace Generator.UnitTests
{
    public abstract class SourceGeneratorTest<TSourceGenerator> : Microsoft.CodeAnalysis.Testing.SourceGeneratorTest<DefaultVerifier>
        where TSourceGenerator : ISourceGenerator, new()
    {
        public SourceGeneratorTest()
        {
            var identity = new PackageIdentity(UnityPackageName, UnityPackageVersion);
            ReferenceAssemblies = ReferenceAssemblies.Default
                .AddPackages(ImmutableArray.Create(identity));
        }


        protected override IEnumerable<ISourceGenerator> GetSourceGenerators()
        {
            yield return new TSourceGenerator();
        }

        // TODO: file extension must be adjusted for vb
        public SourceGeneratorTest<TSourceGenerator> GeneratedSource(string content, string path = StringConstants.GeneratedPath)
        {
            TestState.GeneratedSources.Add((typeof(TSourceGenerator), path, SourceText.From(content, Encoding.UTF8)));

            return this;
        }

        internal static string UnityPackageName
#if NET472
            => "Unity";
#else
            => "Unity.Container";
#endif

        internal static string UnityPackageVersion
        {
            get
            {

#if NET5_0
                return "5.12.0-beta.2";
#else
                var version = typeof(UnityContainer).Assembly.GetName().Version;
                return version.ToString(3);
#endif
            }
        }

    }
}
