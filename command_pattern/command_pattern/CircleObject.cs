using System;
using System.Collections.Generic;
using System.Text;

namespace command_pattern
{
    class CircleObject
    {
        public CircleObject(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public int X { get; }
        public int Y { get; }
        public int R { get; }

        internal void draw()
        {
            //draw circle
        }

        internal void setSize(int size)
        {
            throw new NotImplementedException();
        }

        internal void setColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
