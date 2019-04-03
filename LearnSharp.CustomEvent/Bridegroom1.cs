using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    public class Bridegroom1
    {
        //使用.NET类库中预定义的委托类型EventHandler来定义事件
        public event EventHandler MarryEvent;

        //发出事件
        public void OnMarriageComing(string msg)
        {
            //判断是否绑定了事件处理方法
            if (MarryEvent != null)
            {
                Console.WriteLine(msg);

                //触发事件
                MarryEvent(this,new EventArgs());
            }
        }
    }
}
