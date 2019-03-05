using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Heads
{
    class Bald : Head
    {
        //Properties
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }

        //Methods
        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;

        }
        public override string Talk()
        {
            //base.Talk() if you want both strings then you can do this.
            return "I pity the foo'!";
        }
    }
    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }
}
