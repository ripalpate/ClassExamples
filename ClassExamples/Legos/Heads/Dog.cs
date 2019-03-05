using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Heads
{
    class Dog: Head
    {
        //Methods
        public override string Talk()
        {
            return "Bark! I am dog head...";
        }
        public string Lick()
        {
            return "Tastes like human";
        }
    }
}
