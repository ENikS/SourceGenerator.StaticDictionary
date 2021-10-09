using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using System.Reflection;
using System.Text;

namespace Unity.Precompiler.Source
{
    internal static class ExtensionEmitter
    {
        /// <summary>
        /// Emit source with common code of the Precompiled extension
        /// </summary>
        public static void Emit(this GeneratorPostInitializationContext context)
        {
            var template = $"{typeof(ExtensionEmitter).Namespace}.Templates.Precompiled.cs";

            using Stream stream = typeof(UnityPrecompiler).Assembly.GetManifestResourceStream(template);
            using StreamReader reader = new(stream);

            var source = SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
            context.AddSource($"Unity.Precompiled.Generated.cs", source);
        }


        /// <summary>
        /// Emit source with version specific code of the Precompiled extension
        /// </summary>
        public static void Emit(this GeneratorExecutionContext context, AssemblyName assembly)
        {
            var template = $"{typeof(ExtensionEmitter).Namespace}.Templates.Extension.Precompiled.v{assembly.Version.Major}.cs";

            using Stream stream = typeof(UnityPrecompiler).Assembly.GetManifestResourceStream(template);
            using StreamReader reader = new(stream);

            var source = SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
            context.AddSource($"Unity.Precompiled.Generated.v{assembly.Version.Major}.cs", source);
        }
    }
}
