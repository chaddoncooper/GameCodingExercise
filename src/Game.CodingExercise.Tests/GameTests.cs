using Xunit;

namespace Game.CodingExercise.Tests
{
    public class GameTests
    {
        [Theory]
        [InlineData("RFUFLFFUL", "2 2 -2 W")]
        [InlineData("UFFLUFFLUFFFFDD", "-2 1 2 S")]
        public void MovesProduceExcpetedOutput(string moves, string expected)
        {
            var game = Game.GetDefaultSinglePlayerGame();
            Assert.Equal(expected, game.Move(moves));
        }
    }
}
