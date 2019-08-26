using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.addMenuItem("Salmon", "Fresh Japanese Salmon.", 25.90);
            summerMenu.addMenuItem("Taco", "Fresh Mexican Taco.", 9.90);
            summerMenu.hospitalDirection = "To the left then to the right.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.addMenuItem("Beear", "Chinese qindao.", 1.00);
            outsideDrinks.addMenuItem("Coke", "Americam coke.", 3.00);
            outsideDrinks.disclaimer = "Do not drink and fly.";

            Order hungryClient = new Order();

            for(int x=0; x<=summerMenu.items.Count-1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryClient.items.Add(currentItem);
            }

            foreach(MenuItem currentItem in outsideDrinks.items)
            {
                hungryClient.items.Add(currentItem);
            }

            Console.WriteLine("This is the total: " + hungryClient.Total);

            try
            {
                outsideDrinks.addMenuItem("Water", "Free sink water.", 0);
            }
            catch(Exception throwException)
            {
                Console.WriteLine(throwException.Message);
            }

            Console.ReadKey();


        }
    }
}
