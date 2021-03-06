﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomDelegate   
{
    //委托使用的演示
    class Program
    {
        //1、使用delegate关键字来定义一个委托类型
        delegate void MyDelegate(int para1, int para2);

        static void Main(string[] args)
        {   
            ////2、声明委托变量d
            //MyDelegate d;

            ////3实例化委托类型，传递的方法也可以为静态方法，这里传递的是静态方法
            //d = new MyDelegate(new Program().Add);

            ////4、委托类型作为参数传递给另一个方法
            //MyMethod(d);

            Program p = new Program();
            p.Greeting("李志", p.ChineseGreeting);
            p.Greeting("Tommy Li", p.EnglishGreeting);

            Console.Read();
            var y = Console.Read();

        }

        //该方法的定义必须与委托类型相同，即返回类型为void，两个int类型的参数
        void Add(int para1, int para2)
        {
            int sum = para1 + para2;

            Console.WriteLine("两个数的和为：" + sum);
        }

        //参数的方法是委托类型
        private static void MyMethod(MyDelegate myDelegate)
        {
            myDelegate(1, 2);
        }


        //定义委托类型
        public delegate int GreetingDelegate(string name);

        //有了委托之后，可以像下面这样实现打招呼的方法
        public void Greeting(string name, GreetingDelegate callback)
        {
            var ttt = callback.Invoke(name);
            Console.WriteLine(ttt);
        }

        public int EnglishGreeting(string name)
        {
            Console.WriteLine("Hello," + name);
            return 1;
        }

        public int ChineseGreeting(string name)
        {
            Console.WriteLine("你好，" + name);
            return 2;
        }
    }
}
