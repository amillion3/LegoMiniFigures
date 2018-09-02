using System;

namespace LegoMiniFigures.Head
{
    class HeadBald : HeadBase
    {
        public override bool HasHair { get { return false; } }
        public int Shinyness { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Bald headed man eats food.");
            Console.ReadLine();
        }
    }
}
