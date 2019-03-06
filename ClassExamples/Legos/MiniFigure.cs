using ClassExamples.Legos.Heads;
using ClassExamples.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples.Legos
{
    class MiniFigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public Legs.Legs Legs { get; set; } //because namespace and type are same so have to use it with namespace.type
        public string Name { get; set; }
        

        public MiniFigure(string name, Head head, Torso body, Legs.Legs legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}
        public void Greet()
        {
            Body.Wave();
            Head.Talk();
            Legs.Jump();
        }
    }
}
