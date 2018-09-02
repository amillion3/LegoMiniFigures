using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var baldy = new Head.HeadBald();
            var ladyLegs = new Legs.LegLadies();
            var figureBaldy = new LegoMiniFigure(baldy, ladyLegs);

            var hairy = new Head.HeadHair();
            var manlegs = new Legs.LegMens();
            var figureHairy = new LegoMiniFigure(hairy, manlegs);

            figureBaldy.DoThings();
            figureHairy.DoThings();
        }
    }
}
