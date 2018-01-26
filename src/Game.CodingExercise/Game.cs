using Game.CodingExercise.Models;

namespace Game.CodingExercise
{
    public class Game : IGame
    {
        private readonly IPlayer _player;

        public Game(IPlayer player)
        {
            _player = player;
        }

        public string Move(string input)
        {
            foreach (var move in input)
            {
                InterpretAction(move);
            }

            return GetPlayerPosition();
        }

        public string GetPlayerPosition()
        {
            return _player.GetPosition();
        }

        protected void InterpretAction(char move)
        {
            switch (char.ToUpper(move))
            {
                case ('F'):
                    _player.MoveForward();
                    break;
                case ('L'):
                    _player.TurnLeft();
                    break;
                case ('R'):
                    _player.TurnRight();
                    break;
                case ('U'):
                    _player.MoveUp();
                    break;
                case ('D'):
                    _player.MoveDown();
                    break;
            }
        }

        public static Game GetDefaultSinglePlayerGame()
        {
            var boundaryX = new Boundary(3, -3);
            var boundaryY = new Boundary(3, 0);
            var boundaryZ = new Boundary(3, -3);
            var world = new World(boundaryX, boundaryY, boundaryZ);
            return new Game(new Player(world));
        }
    }
}
