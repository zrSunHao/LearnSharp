using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomGeneric
{
    public class Compare<T> where T :IComparable
    {
        public static T CompareGeneric(T t1, T t2)
        {
            if (t1.CompareTo(t2) > 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }
    }
}
