using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.BasicKnowledge.Polymorphic
{
    public class Horse : Animal
    {
        public override void Voice()
        {
            base.Voice();

            Console.WriteLine("马发出嘶···嘶···的声音");
        }
    }
}
