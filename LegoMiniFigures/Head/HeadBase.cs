using System;

namespace LegoMiniFigures.Head
{
    abstract class HeadBase
    {
        public abstract bool HasHair { get; }

        // Can be overriden, but not required
        public virtual void Talk()
        {
            Console.WriteLine("This is the HeadBase Talk() method");
        }

        // Must be overriden
        public abstract void Eat();
    }
}
