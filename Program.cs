using System;

namespace AnimalShop
{
    class Program

    {
        static void Main(string[] args)
        {
            AnimalShop shop = new AnimalShop();


            // be användaren att välja ett alternativ 
            Console.WriteLine("Welcome to the Animal shop");

            Console.WriteLine("1. Buy animal");
            Console.WriteLine("2. Exit the store");

            string input = Console.ReadLine();
            int option;

            int.TryParse(input, out option);
            while (option != 1 && option != 2)
            {
                // här har en användare valt ett alternativ som ej existerar
                Console.WriteLine("That's not a valid option, try again!");

                input = Console.ReadLine();
                int.TryParse(input, out option);

            }
             

            if (option == 1)
            {   //Användaren ska välja ett av djuren som står i prog.
                Console.Clear();
                Console.WriteLine("Choose one of the animals:  ");
                foreach (var animal in shop.animals)
                {
                    Console.WriteLine(animal.AnimalType);
                }
                string animalTypeInput = Console.ReadLine();
                Animal soldAnimal = shop.Sell(animalTypeInput);


            

                while (soldAnimal == null)
                {
                    Console.Write("Your choice does not exist!\n Please try again:  ");
                    animalTypeInput = Console.ReadLine();
                    soldAnimal = shop.Sell(animalTypeInput);
                }

                soldAnimal.PrintInfo();
                Console.ReadLine();

            }
            else
            {
                Environment.Exit(0);
            }


        }     


        }
    }

