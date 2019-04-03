using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.BasicKnowledge.Polymorphic
{
    public abstract class Animal
    {
        private int _age;

        public int Age
        {
            get { return _age; }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw (new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0-10之间"));
                    _age = value;
                }
            }
        }

        public virtual void Voice()
        {
            Console.WriteLine("动物开始发出声音！");
        }

        public void Eat()
        {
            Console.WriteLine("动物正在进食！");
        }
    }
}
