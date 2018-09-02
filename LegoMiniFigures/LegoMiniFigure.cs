using System;

namespace LegoMiniFigures
{
    class LegoMiniFigure
    {
        private readonly Head.HeadBase _head;
        private readonly Legs.LegBase _leg;
        private readonly Torso.TorsoBase _torso;

        public LegoMiniFigure(Head.HeadBase head, Legs.LegBase leg, Torso.TorsoBase torso)
        {
            _head = head;
            _leg = leg;
            _torso = torso;
        }

        public void DoThings()
        {
            _head.Eat();
            _head.Talk();
            _leg.Walk();
            _leg.Run();
            _torso.Hairy();
            _torso.SucksInGut();
        }
    }
}
