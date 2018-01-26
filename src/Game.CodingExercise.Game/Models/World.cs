namespace Game.CodingExercise.Game.Models
{
    public class World
    {
        public readonly Boundary X;
        public readonly Boundary Y;
        public readonly Boundary Z;

        public World(Boundary x, Boundary y, Boundary z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
