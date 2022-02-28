using MarsRoverCase.Enums;
using MarsRoverCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Model
{
    public class Pilot : IPilot
    {
        private IPosition Position { get; set; }
        private Directions Direction { get; set; }


        public Pilot(IPosition position, Directions direction)
        {
            Position = position;
            Direction = direction;
        }

        /// <summary>
        /// GetPosition
        /// </summary>
        /// <returns></returns>
        public IPosition GetPosition()
        {
            return Position;
        }

        /// <summary>
        /// GetDirection
        /// </summary>
        /// <returns></returns>
        public Directions GetDirection()
        {
            return Direction;
        }
        /// <summary>
        /// TurnLeft
        /// </summary>
        /// <returns></returns>
        public void TurnLeft()
        {
            Direction = (Direction - 1) < Directions.N ? Directions.W : Direction - 1;
        }

        /// <summary>
        /// TurnRight
        /// </summary>
        /// <returns></returns>
        public void TurnRight()
        {
            Direction = (Direction + 1) > Directions.W ? Directions.N : Direction + 1;
        }

        /// <summary>
        /// Pilot
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public void Move()
        {
            if (Direction == Directions.N)
            {
                Position.Y++;
            }
            else if (Direction == Directions.E)
            {
                Position.X++;
            }
            else if (Direction == Directions.S)
            {
                Position.Y--;
            }
            else if (Direction == Directions.W)
            {
                Position.X--;
            }
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (!(other is IPilot toCompareWith))
                return false;
            return Direction == toCompareWith.GetDirection() &&
                Position.Equals(toCompareWith.GetPosition());
        }
    }
}
