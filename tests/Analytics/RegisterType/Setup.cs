using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Unity.Precompiler.Tests;

namespace Invocation.Tests
{
    [TestClass]
    public partial class RegisterTypeTests
    {
        #region Test Data
        public static IEnumerable<object[]> RegisterType_TestData
        {
            get
            {
                //IUnityContainer.RegisterType(Type? contractType, Type implementationType, string? contractName, ITypeLifetimeManager? lifetimeManager, params InjectionMember[] injectionMembers)
                yield return new object[] { "RegisterType((Type)null, typeof(object), (string)null, null, null)" };

                yield return new object[] { "RegisterType<object>()" };
            }
        }

        #endregion
    }
}
