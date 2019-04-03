using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    public class Friend2
    {
        //字段
        public string Name;

        //构造函数
        public Friend2(string name)
        {
            Name = name;
        }

        //事件处理函数，该函数需要符合MarryHandler委托的定义
        public void SendMessage(object s, MarryEventArgs e)
        {
            //对事件做出处理
            Console.WriteLine(this.Name + "收到了，到时候准时参加！");
        }
    }
}
