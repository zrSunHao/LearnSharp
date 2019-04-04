using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomGeneric1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;

            //不使用类型推断的代码
            GenericMethod<int>(ref n1,ref n2);

            //使用类型推断的代码
            GenericMethod(ref n1, ref n2);
            Console.WriteLine("n1的值现在为：" + n1);
            Console.WriteLine("n2的值现在为：" + n2);

            string str1 = "123";
            object obj = "456";

            //使用类型推断时可能会出现编译错误
            //GenericMethod(ref str1,ref obj);
            Console.Read();
        }

        private static void GenericMethod<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }
}
