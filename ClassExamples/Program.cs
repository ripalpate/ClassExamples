using ClassExamples.Legos;
using ClassExamples.Legos.Heads;
using ClassExamples.Legos.Torsos;
using System;

namespace ClassExamples
{
    class Program
    {
        //private string _myData = "this is just for me to use";

        //public int Number { get; set; }

        //public void DoTheThing() {
        //    Number = 1;
        //    var x = Number;
        //}

        private static void Main(string[] args)
        {
            //var taffy = new Candy         //type intialization
            //{
            //Flavor = "Orange",
            //Name = "Orange SaltWater Taffy",
            //Rating = 5,
            //Type = CandyType.Stretchy
            //};
            var taffy = new Candy("Orange", "Orange Taffy", CandyType.Stretchy);
            taffy.SetRating(10);
            taffy.SetRating(5, "don't like it.");
            Console.WriteLine(taffy);

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaught = new Astronaut();

            var fitTorso = new FitTorso(2, Sex.Male, Legos.Colors.Freckles);
            fitTorso.Crunch(12);


            var minifigure = new MiniFigure(martinHead, fitTorso);
            minifigure.Greet();
            Console.ReadLine();
        }
    }
}
