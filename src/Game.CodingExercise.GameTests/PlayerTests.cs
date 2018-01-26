using Game.CodingExercise.Game;
using Game.CodingExercise.Game.Models;
using Xunit;

namespace Game.CodingExercise.GameTests
{
    public class PlayerTests
    {
        private readonly World _world;

        public PlayerTests()
        {
            var boundaryX = new Boundary(3, -1);
            var boundaryY = new Boundary(3, 0);
            var boundaryZ = new Boundary(3, -3);
            _world = new World(boundaryX, boundaryY, boundaryZ);
        }

        [Fact]
        public void ShouldFaceCorrectDirectionAfterTurningRight()
        {
            var player = new Player(_world);
            string[] correctHeadings = { "E", "S", "W", "N" };
            foreach (var correctHeading in correctHeadings)
            {
                player.TurnRight();
                Assert.EndsWith(correctHeading, player.GetPosition());
            }
        }

        [Fact]
        public void ShouldFaceCorrectDirectionAfterTurningLeft()
        {
            var player = new Player(_world);
            string[] correctHeadings = { "W", "S", "E", "N" };
            foreach (var correctHeading in correctHeadings)
            {
                player.TurnLeft();
                Assert.EndsWith(correctHeading, player.GetPosition());
            }
        }

        [Fact]
        public void ShouldMoveUpWithinBoundaries()
        {
            var player = new Player(_world);
            string[] correctPositions = { "0 1 0 N", "0 2 0 N", "0 3 0 N", "0 3 0 N" };
            for (var i = 0; i <= correctPositions.Length - 1; i++)
            {
                player.MoveUp();
                Assert.Equal(correctPositions[i], player.GetPosition());
            }
        }

        [Fact]
        public void ShouldMoveDownWithinBoundaries()
        {
            var player = new Player(_world, y: 3);
            string[] correctPositions = { "0 2 0 N", "0 1 0 N", "0 0 0 N", "0 0 0 N" };
            for (var i = 0; i <= correctPositions.Length - 1; i++)
            {
                player.MoveDown();
                Assert.Equal(correctPositions[i], player.GetPosition());
            }
        }
    }
}
