using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Invocation.Tests
{
    [TestClass]
    public partial class ResolveTests
    {
        #region Test Data
        public static IEnumerable<object[]> IUnityContainer_TestData
        {
            get
            {
                // v4: object Resolve(Type t, string name, params ResolverOverride[] resolverOverrides)
                // v5: object Resolve(Type type, string name, params ResolverOverride[] overrides)
                
                yield return new object[] { "Resolve(typeof(object), null)" };
                yield return new object[] { "Resolve(typeof(object), null, null)" };
            }
        }

        #endregion
    }
}
