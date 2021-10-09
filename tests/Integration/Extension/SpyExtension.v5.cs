using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Builder;
using Unity.Extension;
using Unity.Policy;
using Unity.Resolution;

namespace Unity.Precompiler.Integration.Tests
{
    public class SpyExtension : UnityContainerExtension,
                                IEnumerable<Type>
    {
        private ResolveDelegateFactory _policy;
        private readonly IList<Type> _types = new List<Type>();

        private ResolveDelegate<BuilderContext> Factory(ref BuilderContext context)
        {
            _types.Add(context.Type);
            return _policy.Invoke(ref context);
        }

        protected override void Initialize()
        {
            _policy = (ResolveDelegateFactory)Context.Policies
                .Get(null, null, typeof(ResolveDelegateFactory));

            Context.Policies.Set(null, null, typeof(ResolveDelegateFactory), (ResolveDelegateFactory)Factory);
        }

        public IEnumerator<Type> GetEnumerator()
            => _types.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public int Count => _types.Count;
    }
}
