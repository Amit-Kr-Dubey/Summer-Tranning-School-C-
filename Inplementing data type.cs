using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Datatype_
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            object o = i;
            Console.WriteLine(o.ToString());
            int j = (int)o;
            Console.WriteLine(j.ToString());
            Console.Read();
        }
    }
}
