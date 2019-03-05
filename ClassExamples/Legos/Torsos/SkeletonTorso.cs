using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Torsos
{
    class SkeletonTorso: Torso
    {
        public SkeletonTorso(int numberOFArms) 
            : base(numberOFArms,Sex.Shrug, Colors.Bone, "boney")
        {
        }

        public void Rattle()
        {
            Console.WriteLine("Rattle Rattle....");
            Wave();
        }
    }
}
