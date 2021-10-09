using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Unity.Precompiler.Visitors
{
    public partial class VisitorSet<TVisitor>
    {
        #region Fields

        private static   Entry[] _data;
        private readonly Meta[]  _meta;

        #endregion


        public struct Entry
        {
            public uint   Hash;
            public string Name;
            public string Assembly;
        }

        [DebuggerDisplay($"{{GetDebuggerDisplay(),nq}}")]
        public struct Meta
        {
            #region Fields

            public int Next;
            public int Position;

            #endregion

            #region Constructors

            public Meta(int location, int position)
            {
                Next = location;
                Position = position;
            }

            #endregion

            private string GetDebuggerDisplay()
            {
                return 0 == Position && 0 == Next
                    ? nameof(string.Empty)
                    : $"Position = {Position}, Next = {Next}";
            }
        }
    }
}
