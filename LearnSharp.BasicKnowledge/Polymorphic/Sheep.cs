using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.BasicKnowledge.Polymorphic
{
    public class Sheep : Animal
    {
        public override void Voice()
        {
            base.Voice();

            Console.WriteLine("羊发出咩···咩···的声音");
        }
    }
}
