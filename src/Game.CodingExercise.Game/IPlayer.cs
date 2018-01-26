namespace Game.CodingExercise.Game
{
    public interface IPlayer
    {
        bool MoveForward();
        bool MoveBackward();
        void TurnLeft();
        void TurnRight();
        void MoveUp();
        void MoveDown();
        string GetPosition();
    }
}
