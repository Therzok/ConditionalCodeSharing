using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionallyCompiledSharedCode
{
    public partial class ConditionalCompilation
    {
        public void ConditionalCode()
        {
#if HOST
            Console.WriteLine(typeof(ConditionalCompilation).AssemblyQualifiedName + " Host");
#elif CLIENT
            Console.WriteLine(typeof(ConditionalCompilation).AssemblyQualifiedName + " Client");
#endif
        }

        public void ComplexCode(string arg1) => OnComplexCode(arg1);

        partial void OnComplexCode(string arg1);
    }
}
