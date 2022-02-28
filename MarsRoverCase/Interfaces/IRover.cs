using MarsRoverCase.Enums;
using MarsRoverCase.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Interfaces
{
    public interface IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPilot Pilot { get; set; }
        string ToString();
    }
}
