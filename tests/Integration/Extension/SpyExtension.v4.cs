using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.Precompiler.Integration.Tests
{
    public class SpyExtension : UnityContainerExtension, 
                                IBuildPlanCreatorPolicy,
                                IEnumerable<Type>
    {
        private IBuildPlanCreatorPolicy _factory;
        private readonly IList<Type> _types = new List<Type>();

        public IBuildPlanPolicy CreatePlan(IBuilderContext context, NamedTypeBuildKey buildKey)
        {
            _types.Add(buildKey.Type);
            return _factory.CreatePlan(context, buildKey);
        }

        protected override void Initialize()
        {
            _factory = (IBuildPlanCreatorPolicy)Context.Policies
                .Get(typeof(IBuildPlanCreatorPolicy), null, false, out var _);

            Context.Policies.SetDefault<IBuildPlanCreatorPolicy>(this);
        }

        public IEnumerator<Type> GetEnumerator() 
            => _types.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() 
            => GetEnumerator();

        public int Count => _types.Count;
    }
}
