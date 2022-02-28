using MarsRoverCase.Enums;
using MarsRoverCase.Interfaces;
using MarsRoverCase.Model;
using System;

namespace MarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Test Input:__");
            Console.WriteLine();
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine();
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();
            //First rover 
            Plateau plateauOne = new Plateau(new Position(5, 5));
            IPilot pilotOne = new Pilot(new Position(1, 2), Directions.N);
            Rover firstRover = new Rover(plateauOne, pilotOne);
            RoverController.ExecuteCommands("LMLMLMLMM", firstRover);

            //Second rover 
            IPilot pilotTwo = new Pilot(new Position(3, 3), Directions.E);
            Rover secondRover = new Rover(plateauOne, pilotTwo);
            RoverController.ExecuteCommands("MMRMMRMRRM", secondRover);

            Console.WriteLine("__Expected Output:__");
            Console.WriteLine();
            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
