using Microsoft.CodeAnalysis;
using System;
using System.Reflection;
using Unity.Precompiler.Analysis;

namespace Unity.Precompiler.Storage
{
    public partial class Visitors
    {


        #region Properties

        public static Visitors Default { get; } = new Visitors(new Metadata[1]);

        #endregion


        #region Public API

        public static Visitors Create(AssemblyName assembly, OperationKind kind)
        {
            throw new NotImplementedException();
            //var meta = new Metadata[_all.Length];
            //var version = assembly.Version.ToString();

            //for (var data = 1; data < _data.Length; data++)
            //{
            //    ref var entry = ref _data[data];
            //    if (entry.Kind != kind || !(entry.Version?.IsMatch(version) ?? true))
            //        continue;

            //    var bucket = entry.Hash % meta.Length;
            //    meta[data].Next = meta[bucket].Position;
            //    meta[bucket].Position = data;
            //}

            //return new Visitors(meta);
        }


        //public Func<IOperation, AnalyticModel?>? GetParser(OperationKind kind)
        //{
        //    var hash = (uint)kind ^ 0;
        //    var position = _meta[hash % _meta.Length].Position;

        //    while (position > 0)
        //    {
        //        ref var candidate = ref _data[position];

        //        if (candidate.Kind == kind)
        //            return candidate.Visitor;

        //        position = _meta[position].Next;
        //    }

        //    return null;
        //}

        //public Func<IOperation, AnalyticModel?>? GetParser(OperationKind kind, string name)
        //{
        //    var hash = (uint)((uint)kind ^ name.GetHashCode());
        //    var position = _meta[hash % _meta.Length].Position;

        //    while (position > 0)
        //    {
        //        ref var candidate = ref _data[position];

        //        if (candidate.Kind == kind && candidate.Name == name)
        //            return candidate.Visitor;

        //        position = _meta[position].Next;
        //    }

        //    return null;
        //}

        #endregion
    }
}
