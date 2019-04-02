using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSharp.BasicKnowledge.OperatorLoading;

namespace LearnSharp.BasicKnowledge
{
    public class Program
    {
        static void Main(string[] args)
        {
            //初始化两个复数
            var complex1 = new Complex(1,2);
            var complex2 = new Complex(3, 4);

            var sum = complex1 + complex2;

            Console.WriteLine("第一个复数为：{0}", complex1);
            Console.WriteLine("第一个复数为：{0}", complex2);
            Console.WriteLine("两个复数的和为：{0}", sum);

            Console.Read();
        }
    }
}
