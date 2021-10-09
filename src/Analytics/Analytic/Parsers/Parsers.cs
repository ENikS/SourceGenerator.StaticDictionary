using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Unity.Precompiler.Storage;
using Metadata = Unity.Precompiler.Storage.Metadata;

namespace Unity.Precompiler.Analysis
{
    public class Parsers
    {
        #region Fields

        private static   Entry[]    _data;
        private static   Metadata[] _all;
        private readonly Metadata[] _meta;

        #endregion


        #region Constructors

        static Parsers()
        {
            _data = (new Entry[] { default }).Concat(   
                     new Type[] 
                     { 
                         // We know parser facotries by name
                         typeof(IUnityContainer),
                         typeof(RegisterMethodParsers), 
                         typeof(ResolveMethodParsers),
                         typeof(UnityV4),
                         typeof(UnityV5),
                         typeof(UnityV6),
                     }
                     .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
                     .Where(type => type.IsDefined(typeof(ParserAttribute), false))
                     .Select(method =>
                     {
                         var attribute = method.GetCustomAttribute<ParserAttribute>();
                         return new Entry
                         (
                             attribute.Kind, 
                             attribute.Name, 
                             attribute.Version,
                             (Func<IOperation, AnalyticModel?>)Delegate.CreateDelegate(typeof(Func<IOperation, AnalyticModel?>), method),
                             (uint)((uint)attribute.Kind ^ (attribute.Name?.GetHashCode() ?? 0))
                         );
                     }))
                     .ToArray();

            _all = new Metadata[Prime.Numbers[Prime.NextUp(_data.Length)]];

            for (var data = 1; data < _data.Length; data++)
            {
                var bucket = _data[data].Hash % _all.Length;
                _all[data].Next = _all[bucket].Position;
                _all[bucket].Position = data;
            }
        }

        protected Parsers(Metadata[] meta) => _meta = meta;

        #endregion


        #region Properties

        public static Parsers Default { get; } = new Parsers(new Metadata[1]);

        #endregion


        #region Public API

        public static Parsers Create(AssemblyName assembly, OperationKind kind)
        {
            var meta = new Metadata[_all.Length];
            var version = assembly.Version.ToString();

            for (var data = 1; data < _data.Length; data++)
            {
                ref var entry = ref _data[data];
                if (entry.Kind != kind || !(entry.Version?.IsMatch(version) ?? true))
                    continue;

                var bucket = entry.Hash % meta.Length;
                meta[data].Next = meta[bucket].Position;
                meta[bucket].Position = data;
            }

            return new Parsers(meta);
        }


        public Func<IOperation, AnalyticModel?>? GetParser(OperationKind kind)
        {
            var hash = (uint)kind ^ 0;
            var position = _meta[hash % _meta.Length].Position;

            while (position > 0)
            {
                ref var candidate = ref _data[position];

                if (candidate.Kind == kind)
                    return candidate.Visitor;

                position = _meta[position].Next;
            }

            return null;
        }

        public Func<IOperation, AnalyticModel?>? GetParser(OperationKind kind, string name)
        {
            var hash = (uint)((uint)kind ^ name.GetHashCode());
            var position = _meta[hash % _meta.Length].Position;

            while (position > 0)
            {
                ref var candidate = ref _data[position];

                if (candidate.Kind == kind && candidate.Name == name)
                    return candidate.Visitor;

                position = _meta[position].Next;
            }

            return null;
        }

        #endregion


        #region Storage

        [DebuggerDisplay($"{{Name,nq}}")]
        public struct Entry
        {
            public readonly uint Hash;
            public readonly string? Name;
            public readonly Regex? Version;
            public readonly OperationKind Kind;
            public readonly Func<IOperation, AnalyticModel?> Visitor;

            public Entry(OperationKind kind, string ? name, Regex? version, Func<IOperation, AnalyticModel?> visitor, uint hash)
            {
                Kind    = kind;
                Name    = name;
                Hash    = hash;
                Version = version;
                Visitor = visitor;
            }
        }


        #endregion
    }
}
