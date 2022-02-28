using MarsRoverCase.Interfaces;
using MarsRoverCase.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase
{
    public static class RoverController
    {
        public static void ExecuteCommands(string commands, Rover rover)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        rover.TurnLeft();
                        break;
                    case ('R'):
                        rover.TurnRight();
                        break;
                    case ('M'):
                        rover.Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }
    }
}
