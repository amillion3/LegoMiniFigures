using System;

namespace LegoMiniFigures.Head
{
    class HeadHair : HeadBase
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Brown"; } }
        public string HairTexture { get { return "Straight"; } }

        public override void Eat()
        {
            Console.WriteLine("Brown, straight hair people eat stuff.");
            Console.ReadLine();
        }
    }
}
