using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Heads
{
    class Astronaut: Head
    {
        //Properties
        
        public List<string> Accessories { get; set; }
 
        //Methods
        public override string Talk()
        {
            return $"Houston we have a problem...I have {HairLength} " +
                $"long hair and I am {Color}and my ears are {EarSize}";
        }
    }
}
