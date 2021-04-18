extern alias Client; 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of direct referencing, reflection has no problem here.
            var compilation = new ConditionallyCompiledSharedCode.ConditionalCompilation();
            compilation.ComplexCode("a");
            compilation.ConditionalCode();

            var compilation2 = new Client::ConditionallyCompiledSharedCode.ConditionalCompilation();
            compilation2.ComplexCode("a");
            compilation2.ConditionalCode();
        }
    }
}
