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
            //Create an interactive console window
            //Prompt user to choose what to with the fridge
            //Call mehods on Fride object to do what the user wants
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);
            int userChoice;
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulb, type 2");
                Console.WriteLine("TO clean, type 3");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                //Console.WriteLine("To resert type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater(); //method type was void
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBubls()); //prints out the string...method type was string
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("How much food do you want? Please enter a number of items.");
                        int usersFood = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(usersFood);
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies()); //displays to the console the method CheckSupplies
                        break;
                    case 6:
                        Console.WriteLine(userFridge.DispenserType);
                        Console.WriteLine(userFridge.ChangeBubls());
                        Console.WriteLine(userFridge.Clean());
                        Console.WriteLine(userFridge.FoodAmount);
                        break;
                }
            } while (userChoice != 8);
        }
    }
}
