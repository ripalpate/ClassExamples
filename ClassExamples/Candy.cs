using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples
{
    class Candy
    {
        //public string Flavor { get; set; }
        //public int Rating { get; set; }
        //public string Name { get; set; }
        //public CandyType Type { get; set; }

        // Properties
        public string Flavor { get; }
        public int Rating { get; private set; } = 1; //initialize property at 1
        public string Review { get; private set; }
        public string Name { get; }
        public CandyType Type { get; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Consructor
        public Candy(string flavor, string name, CandyType type) { // sets it privately
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods
        public void SetRating(int userRating)
        {
            //needs to be between 0 -10
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}");
            }
            
        }
        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        //    public void setRating(bool likedIt) => Rating = likedIt ? 10 : 1;
        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor}, rated{Rating} with review of {Review}";
        }
    }

    enum CandyType
    {
         Chocolate,
         HardCandy,
         Caramel,
         Sour,
         Stretchy,
         Nut
    }
}
