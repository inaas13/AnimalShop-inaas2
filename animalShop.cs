using System;
using System.Collections.Generic;

namespace AnimalShop
{

    //1. When should you use private instead of public?
    //  I should use private when i want the type or member to only be accessed
    //by the code in the same class or struct.




    //2. When is it useful to have multiple constructor functions?
    // Basically, I can use multiple constructurs för "convinience"
    // //



    class AnimalShop
    {
        public Animal[] animals;
        private decimal _capital = 0;

        public AnimalShop()
        {
            animals = new Animal[3];

            Dog myDog = new Dog()

            {
                //fyll i alla egenskaper för alla djur

                AnimalType = "Dog",
                Name = "David",
                Age = 2,
                Price = 100,
                HasName = true,
                Legs = 4,
                IsOld = false,

            };
            Owl myOwl = new Owl()
            {
                AnimalType = "Owl",
                Name = "Ozzy",
                Age = 13,
                Price = 300,
                HasName = true,
                Legs = 2,
                HasWings = true,
            };
            Hamster myHamster = new Hamster()
            {
                AnimalType = "Hamster",
                Name = "Harry",
                Age = 4,
                Price = 50,
                HasFur = true,
                IsFast = false,

            };

            animals[0] = myDog;
            animals[1] = myOwl;
            animals[2] = myHamster;
        }

        public Animal Sell(string animalType)

        {  //for loop här 
            for (int i = 0; i < animals.Length; i++)

            {
                if (animals[i].AnimalType.ToLower() == animalType.ToLower().Trim())
                {    //Meddela användaren


                    _capital += animals[i].Price;

                    //Meddela användaren om djuret är sålt

                    Console.WriteLine($"Just sold an animal for ${animals[i].Price}.");
                    Console.WriteLine($"Our capital is currently ${_capital}. ");
                    return animals[i];
                }

            }
            return null;

        }  // skriv ut djurets info från djurets klass





    }
    

    
}
