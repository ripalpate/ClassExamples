using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos.Legs
{
    abstract class Legs
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        public Legs(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("WEEEEEEEEEEEE!!!!!!!!!!!");
        }

        public void Kick(MiniFigure personToKick)
        {
            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. Ha Ha Ha." +
                $" You aren't even scientist");
        }
        public void Walk()
        {
            Console.WriteLine($"{GetType().Name}took few the steps");
        }



    }
    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
