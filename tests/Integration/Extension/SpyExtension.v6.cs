using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Extension;

namespace Unity.Precompiler.Integration.Tests
{
    public class SpyExtension : UnityContainerExtension,
                                IEnumerable<Type>
    {
        private readonly IList<Type> _types = new List<Type>();

        protected override void Initialize()
        {
        }

        public IEnumerator<Type> GetEnumerator()
            => _types.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public int Count => _types.Count;
    }
}
