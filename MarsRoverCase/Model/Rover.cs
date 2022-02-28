using MarsRoverCase.Enums;
using MarsRoverCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Model
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPilot Pilot { get; set; }

        public Rover(IPlateau roverPlateau, IPilot pilot)
        {
            RoverPlateau = roverPlateau;
            Pilot = pilot;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Pilot.GetPosition().X, Pilot.GetPosition().Y, Pilot.GetDirection());
        }

        public void TurnLeft()
        {
            Pilot.TurnLeft();
        }

        public void TurnRight()
        {
            Pilot.TurnRight();
        }

        public void Move()
        {
            Pilot.Move();
        }

        public IPosition GetPosition()
        {
            return Pilot.GetPosition();
        }

        public Directions GetDirection()
        {
            return Pilot.GetDirection();
        }
    }
}
