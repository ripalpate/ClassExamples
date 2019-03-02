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
            Console.WriteLine("Hello World");
        }
    }
}
