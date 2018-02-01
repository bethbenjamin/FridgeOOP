using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create interactive console window
            //prompt user to choose what to do with the fridge
            //call methods on fridge object to do what the user wants
            int userChoice;

            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);//this is outside of the loop, so that it doesnt keep resetting
            do // starts the loop
            {
                Console.WriteLine("Hello, welcome to the fridge");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulb type 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("To  see all fridge details, type 6");
                //Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());


              

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("How much food has been removed?"); //taking in value
                        int amount = int.Parse(Console.ReadLine()); // declaring an int and parsing into the readline
                        userFridge.RemoveFood(amount); //now the userFridge (amount of food has been declared in int amount)
                        break;
                    case 5:
                        Console.WriteLine(userFridge.FoodAmount);
                        break;
                    case 6:
                        Console.WriteLine("you have " +userFridge.FoodAmount +" pounds of food in your fridge");
                        Console.WriteLine("The bulbs are working: " +userFridge.BulbsWork);
                        Console.WriteLine("Your dispenser type is :" +userFridge.DispenserType);
                        Console.WriteLine("Fridge is clean?:" +userFridge.IsClean);
                        break;


                }




            } while (userChoice != 8);
        }
    }
}
