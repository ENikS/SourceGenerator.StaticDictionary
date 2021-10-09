using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Precompiler.Storage
{
    /// <summary>
    /// Internal metadata structure for hash sets and lists
    /// </summary>
    [DebuggerDisplay($"{{GetDebuggerDisplay(),nq}}")]
    public struct Metadata
    {
        #region Fields

        public int Next;
        public int Position;

        #endregion

        #region Constructors

        public Metadata(int location, int position)
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


    public struct MetaSet
    {
        public Metadata[] Data;
        public Metadata[] Meta;

        public MetaSet(int prime = 0)
        {
            Data = new Metadata[Prime.Numbers[prime]];
            Meta = new Metadata[Prime.Numbers[prime + 1]];
        }
    }


    public static class MetadataExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count(this Metadata[] data)
            => data[0].Position;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Count(this Metadata[] data, int count)
            => data[0].Position = count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Increment(this Metadata[] data)
            => ++data[0].Position;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Version(this Metadata[] data)
            => data[0].Next;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Version(this Metadata[] data, int version)
            => data[0].Next = version;

        public static void AddRecord(this Metadata[] data, int location, int position)
        {
            var index = ++data[0].Position;
            ref var record = ref data[index];
            record.Next = location;
            record.Position = position;
        }
    }
}
