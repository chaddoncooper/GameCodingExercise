namespace Game.CodingExercise.Game.Models
{
    public class World
    {
        public readonly Boundary BoundaryX;
        public readonly Boundary BoundaryY;
        public readonly Boundary BoundaryZ;

        public World(Boundary x, Boundary y, Boundary z)
        {
            BoundaryX = x;
            BoundaryY = y;
            BoundaryZ = z;
        }
    }
}
