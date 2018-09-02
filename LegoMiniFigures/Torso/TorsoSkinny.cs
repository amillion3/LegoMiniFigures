using System;

namespace LegoMiniFigures.Torso
{
    class TorsoSkinny : TorsoBase
    {
        public override bool HasGut { get { return false; } }

        public override void Hairy()
        {
            Console.WriteLine("Not really hairy");
            Console.ReadLine();
        }

        public override void SucksInGut()
        {
            Console.WriteLine("No gut sucking necessary!");
        }
    }
}
