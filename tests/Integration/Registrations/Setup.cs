using Microsoft.VisualStudio.TestTools.UnitTesting;
#if UNITY_V4
using Microsoft.Practices.Unity;
#else
using Unity;
#endif

namespace Unity.Precompiler.Integration.Tests
{
    [TestClass]
    public partial class RegistrationTests
    {
        IUnityContainer Container;
        SpyExtension Spy;

        [TestInitialize]
        public void InitializeTest()
        {
            Spy = new SpyExtension();
            Container = new UnityContainer()
                .AddExtension(Spy)
                .AddExtension(new Unity.Precompiled());
        }

        [TestMethod]
        public void Baseline()
        {
            Assert.IsNotNull(Container);
            Assert.IsNotNull(Spy);
            Assert.AreEqual(0, Spy.Count);
        }
    }
}
