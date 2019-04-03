using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.ChainDelegate
{
    class Program
    {
        public delegate void DelegateTest();

        static void Main(string[] args)
        {
            //用静态方法来实例化委托
            DelegateTest dtStatic = new DelegateTest(Program.Method1);

            DelegateTest dtInstance = new DelegateTest(new Program().Method2);

            //定义一个委托对象，一开始初始化为null，即不代表任何方法
            DelegateTest delegateChain = null;

            //使用“+”符号链接委托，链接多个委托之后就成为了委托链
            delegateChain += dtStatic;
            delegateChain += dtInstance;

            //调用委托链
            delegateChain();

            Console.Read();


        }

        private static void Method1()
        {
            Console.WriteLine("这是静态方法");
        }

        private void Method2()
        {
            Console.WriteLine("这是实例方法");
        }
    }
}
