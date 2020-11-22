using System.Linq;
using MineEscape;
using Xunit;

namespace Test
{
    public class ReadConfigTest
    {
        [Fact]
        public void WhenConfigHasRead()
        {
            // Arrange
            string[] lines = new string[5];

            lines[0] = "5 4";
            lines[1] = "1,1 1,3 3,3";
            lines[2] = "2 4";
            lines[3] = "1 0 N";
            lines[4] = "R M M M M R M";
            
            var game = new ReadConfig(lines).Read();
            
            // Assert
            Assert.True(game.Board != null);
            Assert.True(game.Mines.Any());
            Assert.True(game.Turtle != null);
            Assert.True(game.ExitPoint != null);
        }
    }
}