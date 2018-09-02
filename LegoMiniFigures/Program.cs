using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var baldy = new Head.HeadBald();
            var ladyLegs = new Legs.LegLadies();
            var fatTorso = new Torso.TorsoFat();
            var figureBaldy = new LegoMiniFigure(baldy, ladyLegs, fatTorso);

            var hairy = new Head.HeadHair();
            var manlegs = new Legs.LegMens();
            var skinnyTorso = new Torso.TorsoSkinny();
            var figureHairy = new LegoMiniFigure(hairy, manlegs, skinnyTorso);

            figureBaldy.DoThings();
            figureHairy.DoThings();
        }
    }
}
