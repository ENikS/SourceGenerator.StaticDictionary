using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Unity.Precompiler.Analytics;
using Unity.Precompiler.Storage;

namespace Unity.Storage
{
    public abstract class CompiledSet<TEntry>
        where TEntry : struct
    {
        #region Fields

        protected static TEntry[] _data;
        private static   Metadata[] _all;
        private readonly Metadata[] _meta;

        #endregion


        #region Constructors

        static CompiledSet()
        {
            _data = (new TEntry[] { default }).Concat(
                     new Type[]
                     { 
                         // We know visitor facotries by name
                         typeof(DiagnosticVisitors),
                     }
                     .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
                     .Where(method => method.IsDefined(typeof(CompiledSetEntryAttribute<TEntry>)))
                     .Select(method => (TEntry)default))
                     .ToArray();

            _all = new Metadata[Prime.Numbers[Prime.NextUp(_data.Length)]];

            //for (var data = 1; data < _data.Length; data++)
            //{
            //    var bucket = _data[data].Hash % _all.Length;
            //    _all[data].Next = _all[bucket].Position;
            //    _all[bucket].Position = data;
            //}
        }

        #endregion
    }
}
