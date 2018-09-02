using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var baldy = new Head.HeadBald();
            var figureBaldy = new LegoMiniFigure(baldy);

            var hairy = new Head.HeadHair();
            var figureHairy = new LegoMiniFigure(hairy);

            figureBaldy.DoThings();
            figureHairy.DoThings();
        }
    }
}
