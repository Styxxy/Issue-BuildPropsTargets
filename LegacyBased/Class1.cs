using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyBased
{
    public class Class1
    {
        public void GenerateCodeAnalysisWarning(string foo)
        {
            if (foo == null) throw new ArgumentNullException("foo");
        }
    }
}
