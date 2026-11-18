using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class FoodServices : IFoodServices
    {

        public string RestPick(int restType)
        {
            string restaurant = "";

            int answer;
            Random rnd = new Random();
            answer = rnd.Next(1, 11);

            if (restType == 1)
            {
                if (answer == 1)
                {
                    restaurant = "McDonald's" ;
                }
                else if (answer == 2)
                {
                    restaurant = "In-N-Out" ;
                }
                else if (answer == 3)
                {
                    restaurant = "KFC" ;
                }
                else if (answer == 4)
                {
                    restaurant = "Raising Cane's Chicken" ;
                }
                else if (answer == 5)
                {
                    restaurant = "Panda Express" ;
                }
                else if (answer == 6)
                {
                    restaurant = "Taco Bell" ;
                }
                else if (answer == 7)
                {
                    restaurant = "Burger King" ;
                }
                else if (answer == 8)
                {
                    restaurant = "Wendy's" ;
                }
                else if (answer == 9)
                {
                    restaurant = "El Pollo Loco" ;
                }
                else
                {
                    restaurant = "Dell Taco" ;
                }
            }
            else if (restType == 2)
            {
                if (answer == 1)
                {
                    restaurant = "West Coast Sourdough" ;
                }
                else if (answer == 2)
                {
                    restaurant = "Pizza Hut" ;
                }
                else if (answer == 3)
                {
                    restaurant = "Roundtable" ;
                }
                else if (answer == 4)
                {
                    restaurant = "Mountain Mikes" ;
                }
                else if (answer == 5)
                {
                    restaurant = "Sourdough & Co." ;
                }
                else if (answer == 6)
                {
                    restaurant = "La Estrella" ;
                }
                else if (answer == 7)
                {
                    restaurant = "Mr. Pickles" ;
                }
                else if (answer == 8)
                {
                    restaurant = "Straw Hat Pizza" ;
                }
                else if (answer == 9)
                {
                    restaurant = "Feronis" ;
                }
                else
                {
                    restaurant = "Subway" ;
                }
            }
            else if (restType == 3)
            {
                if (answer == 1)
                {
                    restaurant = "Texas Roadhouse" ;
                }
                else if (answer == 2)
                {
                    restaurant = "Applebees" ;
                }
                else if (answer == 3)
                {
                    restaurant = "Olive Garden" ;
                }
                else if (answer == 4)
                {
                    restaurant = "BJ's" ;
                }
                else if (answer == 5)
                {
                    restaurant = "Chili's" ;
                }
                else if (answer == 6)
                {
                    restaurant = "Las Casuelas" ;
                }
                else if (answer == 7)
                {
                    restaurant = "DJ's Restaurant" ;
                }
                else if (answer == 8)
                {
                    restaurant = "Tap House" ;
                }
                else if (answer == 9)
                {
                    restaurant = "Bistro 120" ;
                }
                else
                {
                    restaurant = "The Boathouse";
                }
            }
            else
            {
                restaurant = "Oops! There seems to be a mistake. Try numbers 1-3!";
            }

            return restaurant;
        }
    }
}