using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomGeneric
{
    public class NoGenericTypeWithStaticField
    {
        public static string Field { get; set; }

        public static void OutField()
        {
            Console.WriteLine(Field);
        }
    }
}
