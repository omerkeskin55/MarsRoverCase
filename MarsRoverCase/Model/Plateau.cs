using MarsRoverCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Model
{
    public class Plateau : IPlateau
    {
        public IPosition PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
