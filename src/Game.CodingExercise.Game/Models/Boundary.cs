namespace Game.CodingExercise.Game.Models
{
    public class Boundary
    {
        public int Min { get; }
        public int Max { get; }

        public Boundary(int max, int min)
        {
            Max = max;
            Min = min;
        }
    }
}
