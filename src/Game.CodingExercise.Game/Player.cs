using System;
using Game.CodingExercise.Game.Models;

namespace Game.CodingExercise.Game
{
    public class Player : IPlayer
    {
        public World World { get; }
        protected int X, Y, Z;
        protected char Facing;
        protected readonly char[] Headings = { 'N', 'E', 'S', 'W' };

        public Player(World world, int x = 0, int y = 0, int z = 0, char facing = 'N')
        {
            World = world;
            X = x;
            Y = y;
            Z = z;
            Facing = facing;
        }

        public void MoveForward()
        {
            int newPosition;

            switch (Facing)
            {
                case 'N':
                    newPosition = Z + 1;
                    if (newPosition <= World.BoundaryZ.Max)
                        Z = newPosition;
                    break;
                case 'E':
                    newPosition = X + 1;
                    if (newPosition <= World.BoundaryX.Max)
                        X = newPosition;
                    break;
                case 'S':
                    newPosition = Z - 1;
                    if (newPosition >= World.BoundaryZ.Min)
                        Z = newPosition;
                    break;
                case 'W':
                    newPosition = X - 1;
                    if (newPosition >= World.BoundaryX.Min)
                        X = newPosition;
                    break;
            }
        }

        public void MoveBackward()
        {
            int newPosition;

            switch (Facing)
            {
                case 'N':
                    newPosition = Z - 1;
                    if (newPosition >= World.BoundaryZ.Min)
                        Z = newPosition;
                    break;
                case 'E':
                    newPosition = X - 1;
                    if (newPosition >= World.BoundaryX.Min)
                        X = newPosition;
                    break;
                case 'S':
                    newPosition = Z + 1;
                    if (newPosition <= World.BoundaryZ.Max)
                        Z = newPosition;
                    break;
                case 'W':
                    newPosition = X + 1;
                    if (newPosition <= World.BoundaryX.Max)
                        X = newPosition;
                    break;
            }
        }

        public void TurnLeft()
        {
            var index = Array.IndexOf(Headings, Facing) - 1;
            Facing = index < 0 ? Headings[Headings.Length - 1] : Headings[index];
        }

        public void TurnRight()
        {
            var index = Array.IndexOf(Headings, Facing) + 1;
            Facing = index == Headings.Length ? Headings[0] : Headings[index];
        }

        public void MoveUp()
        {
            var newPosition = Y + 1;
            if (newPosition <= World.BoundaryY.Max)
                Y = newPosition;
        }

        public void MoveDown()
        {
            var newPosition = Y - 1;
            if (newPosition >= World.BoundaryY.Min)
                Y = newPosition;
        }

        public string GetPosition()
        {
            return $"{X} {Y} {Z} {Facing}";
        }
    }
}
