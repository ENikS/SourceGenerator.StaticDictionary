using System.Text.RegularExpressions;

namespace Unity.Precompiler.Tests
{
    public static class StringConstants
    {
        public const string RegisterTypeConst = "RegisterType";
        public const string Declarations = "Declarations";
        public const string GeneratedPath = "file.cs";
        public const string TestingConst = "Testing";
        public const string TestNamespaces =
#if UNITY_V4
@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
";
#else
@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
";
#endif

        public static Regex DeclarationRegex = new("<!--declaration-->", RegexOptions.Compiled);
    }
}
