using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Legs
{
    class OrangeLegs : Legs
    {
        public OrangeLegs(Length legLength) 
            : base(legLength, Colors.Orange)
        {
            Hairy = true;
            CanBend = true;
        }

        public override void Jump()
        {
            Console.WriteLine("Orange legs loose control and frail about in the air");
        }


    }
}
