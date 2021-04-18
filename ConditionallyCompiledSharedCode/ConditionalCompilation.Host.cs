using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionallyCompiledSharedCode
{
    partial class ConditionalCompilation
    {
        partial void OnComplexCode(string arg1)
        {
            Console.WriteLine(arg1 + " host");
        }
    }
}
