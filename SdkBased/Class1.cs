using System;

namespace SdkBased
{
    public class Class1
    {
        public void GenerateCodeAnalysisWarning(string foo)
        {
            if (foo == null) throw new ArgumentNullException("foo");
        }
    }
}
