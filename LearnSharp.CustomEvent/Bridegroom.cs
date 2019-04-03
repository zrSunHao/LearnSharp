using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    /// <summary>
    /// 新郎官类，充当事件发布者角色
    /// </summary>
    public class Bridegroom
    {
        //自定义委托
        public delegate void MarryHandler(string msg);

        //使用自定义委托事件，事件名为MarryEvent
        public event MarryHandler MarryEvent;

        //发出事件
        public void OnMarriageComing(string msg)
        {
            //判断是否绑定了事件处理方法
            if (MarryEvent != null)
            {
                //触发事件
                MarryEvent(msg);
            }
        }
    }
}
