using Microsoft.VisualStudio.TestTools.UnitTesting;
#if UNITY_V4
using Microsoft.Practices.Unity;
#else
using Unity;
#endif

namespace Unity.Precompiler.Integration.Tests
{
    [TestClass]
    public class PrecompiledExtensionTests
    {
        [TestMethod]
        public void CreateContainer()
        {
            var container = new UnityContainer();

            Assert.IsNotNull(container);
        }

        [TestMethod]
        public void AddGeneratedExtension()
        {
        }
    }
}
