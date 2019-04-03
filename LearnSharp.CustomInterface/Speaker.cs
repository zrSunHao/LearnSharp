using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomInterface
{
    public class Speaker : IChineseGreeting, IAmericanGreeting
    {
        ///// <summary>
        ///// 隐式的实现了两个接口
        ///// </summary>
        //public void SayHello()
        //{
        //    Console.WriteLine("你好！Hello!");
        //}

        /// <summary>
        /// 显示接口实现方式
        /// </summary>
        void IChineseGreeting.SayHello()
        {
            Console.WriteLine("你好！");
        }

        void IAmericanGreeting.SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
