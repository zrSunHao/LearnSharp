using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomInterface
{
    public class Person : ICustomCompare
    {
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// 实现接口方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            Person otherP = (Person) value;
            if (this.Age < otherP.Age)
            {
                return -1;
            }

            if (this.Age > otherP.Age)
            {
                return 1;
            }

            return 0;
        }
    }
}
