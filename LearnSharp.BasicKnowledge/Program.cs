using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSharp.BasicKnowledge.OperatorLoading;
using LearnSharp.BasicKnowledge.Polymorphic;

namespace LearnSharp.BasicKnowledge
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 第三章 运算符重载

            //初始化两个复数
            //var complex1 = new Complex(1, 2);
            //var complex2 = new Complex(3, 4);
            //var sum = complex1 + complex2;

            //Console.WriteLine("第一个复数为：{0}", complex1);
            //Console.WriteLine("第一个复数为：{0}", complex2);
            //Console.WriteLine("两个复数的和为：{0}", sum);

            #endregion

            #region 第五章 多态

            //Animal horse = new Horse();
            //horse.Voice();

            //Animal sheep = new Sheep();
            //sheep.Voice();

            //Horse horse1 = new Horse();
            //horse1.Eat();
            //((Animal)horse1).Eat();

            #endregion

            Console.Read();
        }
    }
}
