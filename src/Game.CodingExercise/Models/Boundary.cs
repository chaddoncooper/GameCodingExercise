using System;

namespace Game.CodingExercise.Models
{
    public class Boundary
    {
        public int Min { get; }
        public int Max { get; }

        public Boundary(int max, int min)
        {
            if (min >= max)
            {
                throw new Exception("Boundary minimum must be less than maximum");
            }
            Max = max;
            Min = min;
        }
    }
}
