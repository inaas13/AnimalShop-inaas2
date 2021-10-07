using System;
namespace AnimalShop
{
    class Owl : Animal
    {
        // Info om djuren
        public int Legs { get; set; }
        public bool HasName { get; set; }
        public bool HasWings { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Legs: {Legs} - HasName: {HasName} - HasWings {HasWings} - ");
        }

    }
}
