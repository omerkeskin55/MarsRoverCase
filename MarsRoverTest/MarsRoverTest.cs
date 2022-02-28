using MarsRoverCase;
using MarsRoverCase.Enums;
using MarsRoverCase.Interfaces;
using MarsRoverCase.Model;
using NUnit.Framework;

namespace MarsRoverTest
{
    [TestFixture]
    public class MarRoverTest
    {
        /// <summary>
        /// Test method for First Rover check output
        /// </summary>
        [Test]
        public void FirstRoverCheckOutput()
        {
            Plateau plateau = new Plateau(new Position(5, 5));
            IPilot pilotOne = new Pilot(new Position(1, 2), Directions.N);
            Rover firstRover = new Rover(plateau, pilotOne);
            RoverController.ExecuteCommands("LMLMLMLMM", firstRover);
            var finalPilot = new Pilot(new Position(1, 3), Directions.N);
            Assert.That(firstRover.Pilot, Is.EqualTo(finalPilot));

        }

        /// <summary>
        /// Test method for Second Rover check output
        /// </summary>
        [Test]
        public void SecondRoverCheckOutput()
        {
            Plateau plateau = new Plateau(new Position(5, 5));
            IPilot pilot2 = new Pilot(new Position(3, 3), Directions.E);
            Rover secondRover = new Rover(plateau, pilot2);
            RoverController.ExecuteCommands("MMRMMRMRRM", secondRover);
            var finalPilot = new Pilot(new Position(5, 1), Directions.E);
            Assert.That(secondRover.Pilot, Is.EqualTo(finalPilot));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void RoverCoordinatesMustBeEqualToInitialCoordinates()
        {
            
            IPosition initialPosition = new Position(0, 0);
            var endPosition = new Position(0, 0);
            IPilot pilot = new Pilot(initialPosition, Directions.E);
            Plateau plateau = new Plateau(new Position(5, 5));      
            var rover = new Rover(plateau, pilot);
            Assert.That(rover.GetPosition(), Is.EqualTo(endPosition));
        }
    }
}