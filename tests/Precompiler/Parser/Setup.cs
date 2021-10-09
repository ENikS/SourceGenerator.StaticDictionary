using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using Unity.Precompiler.Generator.Tests;

namespace Parser.UnitTests
{
    [TestClass]
    public partial class UnityParserTests
    {
        #region Fields

        IEnumerable<MetadataReference> references = new[]
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(FieldInfo).Assembly.Location),
        };

        #endregion


        #region Initialization

        [TestInitialize]
        public void InitializeTest()
        {
        }

        #endregion


        #region Tests

        [TestMethod, TestProperty(StringConstants.TestingConst, nameof(Baseline))]
        public void Baseline()
        {
        }

        #endregion
    }
}
