using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Unity.Precompiler.Analytics;

namespace Unity.Precompiler.Storage
{
    public partial class Visitors
    {
        #region Fields

        private static   Entry[]    _data;
        private static   Metadata[] _all;
        private readonly Metadata[] _meta;

        #endregion


        #region Constructors

        static Visitors()
        {
            _data = (new Entry[] { default }).Concat(   
                     new Type[] 
                     { 
                         // We know visitor facotries by name
                         typeof(DiagnosticVisitors),
                     }
                     .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
//                     .Where(method => method.IsDefined(typeof(ExportAttribute)))
                     .Select(method => new Entry(method)))
                     .ToArray();

            _all = new Metadata[Prime.Numbers[Prime.NextUp(_data.Length)]];

            for (var data = 1; data < _data.Length; data++)
            {
                var bucket = _data[data].Hash % _all.Length;
                _all[data].Next = _all[bucket].Position;
                _all[bucket].Position = data;
            }
        }

        protected Visitors(Metadata[] meta) => _meta = meta;

        #endregion


        #region Storage

        [DebuggerDisplay($"{{Name,nq}}")]
        public struct Entry
        {
            public uint Hash;
            public Type    Type;
            public string  Name;

            public Regex?  Version;
            public string? Assembly;

            public Func<IOperation, IEnumerable<Diagnostic>> Visitor;

            public Entry(MethodInfo method)
            {
                Name = string.Empty;
                Type = typeof(IOperation);
                Version = null;
                Assembly = null;

                //foreach (var attribute in method.GetCustomAttributes()!)
                //{
                //    switch (attribute)
                //    {
                //        case ExportAttribute export:
                //            if (export.ContractName is not null) Name = export.ContractName;
                //            if (export.ContractType is not null) Type = export.ContractType;
                //            break;

                //        case ExportMetadataAttribute metadata:
                //            switch (metadata.Name)
                //            {
                //                case nameof(Version):
                //                    Version = new Regex((string?)metadata.Value, RegexOptions.Compiled);
                //                    break;
                                
                //                case nameof(Assembly):
                //                    Assembly = (string?)metadata.Value;
                //                    break;
                //            }
                //            break;
                //    }
                //}
            
                Visitor = (Func<IOperation, IEnumerable<Diagnostic>>)
                    Delegate.CreateDelegate(typeof(Func<IOperation, IEnumerable<Diagnostic>>), method);
                
                Hash = (uint)Name.GetHashCode();
            }
        }


        #endregion
    }
}
