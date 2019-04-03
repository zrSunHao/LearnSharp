using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomInterface
{
    interface ICustomCompare
    {
        /// <summary>
        /// 定义比较方法，继承该接口的类都要实现该方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int CompareTo(Object other);
    }
}
