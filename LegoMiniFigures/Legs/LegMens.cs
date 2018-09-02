using System;


namespace LegoMiniFigures.Legs
{
    class LegMens : LegBase
    {
        public override string MaleOrFemale { get { return "Man"; } }
        public override bool HairyLegs { get { return false; } }

        public override void Run()
        {
            Console.WriteLine("Hairy man legs run fast");
            Console.ReadLine();
        }
    }
}
