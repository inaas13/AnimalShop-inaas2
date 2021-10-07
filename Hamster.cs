using System;
namespace AnimalShop
{
    class Hamster : Animal
    {
        // Info om djuren
        public bool IsFast { get; set; }
        public string name { get; set; }
        public bool HasFur { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"IsFast: {IsFast} - Name: {Name} - HasFur {HasFur} - ");
        }

       

    }
}
