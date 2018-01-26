using System;

namespace Game.CodingExercise.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var game = Game.GetDefaultSinglePlayerGame();
            var inputString = "";

            do
            {
                Console.Clear();
                Console.WriteLine($"Current Position\n{game.GetPlayerPosition()}");
                Console.WriteLine("Enter you move(s), exit to quit:");
                inputString = Console.ReadLine();
                game.Move(inputString);

            } while (inputString != "exit");
        }
    }
}
