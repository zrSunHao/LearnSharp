using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    public class Bridegroom2
    {
        //自定义委托类型，委托包含两个参数
        public delegate void MarryHandler(object sender, MarryEventArgs e);

        //使用自定义委托事件，事件名为MarryEvent
        public event MarryHandler MarryEvent;

        //发出事件
        public void OnMarriageComing(string msg)
        {
            //判断是否绑定了事件处理方法
            if (MarryEvent != null)
            {
                Console.WriteLine(msg);

                //触发事件
                MarryEvent(this, new MarryEventArgs(msg));
            }
        }

    }
}
