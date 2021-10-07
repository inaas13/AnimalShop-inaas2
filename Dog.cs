using System;
namespace AnimalShop
{
    class Dog : Animal 
    {
        //Info om djuren
        public bool HasName { get; set; }
        public bool IsOld { get; set; }
        public int Legs { get; set; }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"HasName: {HasName} - IsOld: {IsOld} - Legs {Legs} ");
        }
        

    }
}
