using System;

namespace LegoMiniFigures.Legs
{
    abstract class LegBase
    {
        public abstract bool HairyLegs { get; }

        public virtual void Walk()
        {
            Console.WriteLine("This is the LegBase Walk() method");
        }
        // Must be overriden
        public abstract void Run();
    }

}
