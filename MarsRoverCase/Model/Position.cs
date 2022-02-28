using MarsRoverCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Model
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object other)
        {
            if (!(other is IPosition toCompareWith))
                return false;
            return X == toCompareWith.X &&
                Y == toCompareWith.Y;
        }
    }
}
