using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接口的定义

            //创建两个Person对象
            //Person p1 = new Person();
            //p1.Age = 18;
            //Person p2 = new Person();
            //p2.Age = 19;

            ////调用接口中的方法，对p1和p2进行比较
            //if (p1.CompareTo(p2) > 0)
            //{
            //    Console.WriteLine("p1比p2大");
            //}
            //else if (p1.CompareTo(p2) < 0)
            //{
            //    Console.WriteLine("p1比p2小");
            //}
            //else
            //{
            //    Console.WriteLine("p1和p2一样大");
            //}

            #endregion


            #region 显示接口实现方法

            //初始化实例
            Speaker speaker = new Speaker();

            //调用中国人打招呼的方法
            //显式的转化为通过IChineseGreeting接口来调用SayHello方法
            IChineseGreeting iChineseG = (IChineseGreeting) speaker;
            iChineseG.SayHello();

            //调用美国人打招呼的方法
            //显式的转化为通过IAmericanGreeting接口来调用SayHello方法
            IAmericanGreeting iAmericanG = (IAmericanGreeting)speaker;
            iAmericanG.SayHello();

            #endregion

            Console.Read();
        }
    }
}
