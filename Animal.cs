using System;

namespace AnimalShop
{   
    // Basklassen

     class Animal
    {
        public int Price { get; set; }
        public int Age { get; set; }
        public string AnimalType { get; set; }
        public string Name { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {AnimalType} - Name: {Name} - Price {Price} - Age{ Age}");


        }




    }

}
