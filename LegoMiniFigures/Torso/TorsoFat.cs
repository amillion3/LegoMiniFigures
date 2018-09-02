using System;

namespace LegoMiniFigures.Torso
{
    class TorsoFat : TorsoBase
    {
        public override bool HasGut { get { return true; } }

        public override void Hairy()
        {
            Console.WriteLine("Very hairy!");
            Console.ReadLine();
        }

        public override void SucksInGut()
        {
            Console.WriteLine("Sucks in gut for sure!");
            Console.ReadLine();
        }
    }
}
