﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Legs
{
    class ShortsLegs :Legs
    {
        public ShortsLegs(Length legLength, Colors shortsColor, bool isHairy) 
            : base (legLength, shortsColor)
        {
            Hairy = isHairy;
        }
    }
}
