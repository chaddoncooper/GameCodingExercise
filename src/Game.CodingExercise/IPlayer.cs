namespace Game.CodingExercise
{
    public interface IPlayer
    {
        void MoveForward();
        void MoveBackward();
        void TurnLeft();
        void TurnRight();
        void MoveUp();
        void MoveDown();
        string GetPosition();
    }
}
