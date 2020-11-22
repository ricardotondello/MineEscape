using System.Drawing;
using Entities;
using Xunit;

namespace Test
{
    public class TurtleTest
    {
        [Fact]
        public void WhenTurtleRotatesFromNorthToEast()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.N
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.R);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.E);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromEastToSouth()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.E
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.R);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.S);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromSouthToWest()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.S
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.R);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.W);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromWestToNorth()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.W
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.R);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.N);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromNorthToWest()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.N
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.L);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.W);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromWsetToSouth()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.W
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.L);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.S);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromSouthToEast()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.S
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.L);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.E);
        }
        
        [Fact]
        public void WhenTurtleRotatesFromEastToNorth()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.E
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.L);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.N);
        }
        
        [Fact]
        public void WhenActionIsToMoveTheDirectionDoesNotChange()
        {
            // Arrange
            var turtle = new Turtle()
            {
                CurrentPosition = new Position()
                {
                    Position = new Point(0,0), 
                    Direction = Direction.N
                }
            };
            
            // Act
            turtle.DoRotate(TurtleAction.M);
            
            // Assert
            Assert.True(turtle.CurrentPosition.Direction == Direction.N);
        }
    }
}