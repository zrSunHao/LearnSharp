using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnSharp.CustomThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread backThread = new Thread(Worker);
            backThread.IsBackground = true;
            backThread.Start();
            //Thread.Sleep(2000);
            //确保主线程在线程结束后再进行
            //backThread.Join();
            Console.WriteLine("从线程中退出");
        }

        public static void Worker()
        {
            Thread.Sleep(5000);
            Console.WriteLine("从后台线程退出");
        }
    }
}
