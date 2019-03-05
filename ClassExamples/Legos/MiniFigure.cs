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
        //Legs

        public MiniFigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
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
        }
    }
}
