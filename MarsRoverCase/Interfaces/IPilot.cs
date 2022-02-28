using MarsRoverCase.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Interfaces
{
    public interface IPilot
    {
        void TurnLeft();

        void TurnRight();

        void Move();

        IPosition GetPosition();

        Directions GetDirection();

    }
}
