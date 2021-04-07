using System;
using System.Collections.Generic;
using DrinkTypes.Models;

namespace DrinkTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var orangeJuice = new Juice("Orange Juice", false, JuiceIngredient.Orange);
            var budweiserBeer = new Beer("Budweiser", true, 4.5);
            var pepsi = new Soda("Pepsi", true);
            
            var listOfDrinks = new List<Drink>{orangeJuice, budweiserBeer, pepsi};
            foreach (var drink in listOfDrinks)
            {
                Console.WriteLine(drink.GetDescription());
            }
            
            try
            {
                // trying to create a drink with empty name
                var namelessSoda = new Soda("", false);
                Console.WriteLine(namelessSoda.GetDescription());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                // trying to create alien beer 
                var alienDrink = new Beer("Alien Beer", false, 1000);
                Console.WriteLine(alienDrink.GetDescription());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}