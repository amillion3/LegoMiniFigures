using System;

namespace LegoMiniFigures
{
    class LegoMiniFigure
    {
        private readonly Head.HeadBase _head;
        private readonly Legs.LegBase _leg;

        public LegoMiniFigure(Head.HeadBase head, Legs.LegBase leg)
        {
            _head = head;
            _leg = leg;
        }

        public void DoThings()
        {
            _head.Eat();
            _head.Talk();
            _leg.Walk();
            _leg.Run();
        }
    }
}
