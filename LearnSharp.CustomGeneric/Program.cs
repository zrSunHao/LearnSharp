using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 入门

            //Console.WriteLine(Compare<int>.CompareGeneric(3, 4));

            //Console.WriteLine(Compare<string>.CompareGeneric("abc", "a"));

            //TestGeneric();

            //TestNoGeneric();

            #endregion

            //Dictionary<,>是一个开放类型，它有两个类型参数
            Type t = typeof(Dictionary<,>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);

            //DictionaryStringKey<>也是一个开放类型，但它只有一个参数
            t = typeof(DictionaryStringKey<>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);

            //DictionaryStringKey<int>是一个封闭类型
            t = typeof(DictionaryStringKey<int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);

            //Dictionary<int,int>是一个封闭类型
            t = typeof(Dictionary<int, int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);

            Console.Read();
        }


        public static void TestGeneric()
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> genericlist = new List<int>();

            stopwatch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                genericlist.Add(i);
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("泛型类的运行时间：  " + elapsedTime);
        }


        public static void TestNoGeneric()
        {
            Stopwatch stopwatch = new Stopwatch();

            ArrayList genericlist = new ArrayList();

            stopwatch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                genericlist.Add(i);
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("非泛型类的运行时间：  " + elapsedTime);
        }
    }
}
