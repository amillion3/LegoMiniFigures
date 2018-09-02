using System;

namespace LegoMiniFigures
{
    class LegoMiniFigure
    {
        private readonly Head.HeadBase _head;

        public LegoMiniFigure(Head.HeadBase head)
        {
            _head = head;
        }

        public void DoThings()
        {
            _head.Eat();
            _head.Talk();
        }
    }
}
