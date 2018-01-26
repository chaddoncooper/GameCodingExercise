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

        public bool MoveForward()
        {
            throw new NotImplementedException();
        }

        public bool MoveBackward()
        {
            throw new NotImplementedException();
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
