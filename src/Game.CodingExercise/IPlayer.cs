namespace Game.CodingExercise
{
    public interface IPlayer
    {
        void MoveForward();
        void TurnLeft();
        void TurnRight();
        void MoveUp();
        void MoveDown();
        string GetPosition();
    }
}
