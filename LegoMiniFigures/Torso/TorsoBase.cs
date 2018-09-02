using System;

namespace LegoMiniFigures.Torso
{
    abstract class TorsoBase
    {
        public abstract bool HasGut { get; }

        public virtual void Hairy()
        {
            Console.WriteLine("A hairy chest.");
        }

        public abstract void SucksInGut();
    }
}
