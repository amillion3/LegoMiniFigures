using System;

namespace LegoMiniFigures.Legs
{
    class LegLadies : LegBase
    {
        public override string MaleOrFemale { get { return "Female"; } }
        public override bool HairyLegs { get { return false; } }

        public override void Run()
        {
            Console.WriteLine("Non-hairy lady legs run even faster!");
            Console.ReadLine();
        }
    }
}
