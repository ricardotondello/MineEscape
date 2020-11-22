using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Entities;
using MineEscape;
using Utils;
using Xunit;

namespace Test
{
    public class MineEscapeTest
    {
        [Fact]
        public void WhenGameHasPlayedSuccessfully()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            actions.Add(TurtleAction.M);
            actions.Add(TurtleAction.L);
            actions.Add(TurtleAction.M);
            
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                }
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(results.Last().IsSome);
        }
        
        [Fact]
        public void WhenGameHasStillInDanger()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            actions.Add(TurtleAction.M);
            
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                }
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(results.Last().Message == ResultEnum.InDanger.ToDescriptionString());
        }
        
        [Fact]
        public void WhenGameHasHitByAMine()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            actions.Add(TurtleAction.M);
            
            var mines = new List<Mine>();
            mines.Add(new Mine()
            {
                Position = new Point(0,0)
            });
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                },
                Mines = mines
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(results.Last().Message == ResultEnum.MineHit.ToDescriptionString());
        }
        
        [Fact]
        public void WhenGameDoesTheTurtleGoToEast()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.M);
            
            var mines = new List<Mine>();
            mines.Add(new Mine()
            {
                Position = new Point(0,0)
            });
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                },
                Mines = mines
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(game.Turtle.CurrentPosition.Direction == Direction.E);
        }
        
        [Fact]
        public void WhenGameDoesTheTurtleGoToWest()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            actions.Add(TurtleAction.M);
            
            var mines = new List<Mine>();
            mines.Add(new Mine()
            {
                Position = new Point(0,0)
            });
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                },
                Mines = mines
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(game.Turtle.CurrentPosition.Direction == Direction.W);
        }
        
        [Fact]
        public void WhenGameDoesTheTurtleGoToSouth()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.M);
            
            var mines = new List<Mine>();
            mines.Add(new Mine()
            {
                Position = new Point(0,0)
            });
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                },
                Mines = mines
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(game.Turtle.CurrentPosition.Direction == Direction.S);
        }
        
        [Fact]
        public void WhenGameDoesTheTurtleGoToNorth()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.R);
            actions.Add(TurtleAction.M);
            
            var mines = new List<Mine>();
            mines.Add(new Mine()
            {
                Position = new Point(0,0)
            });
            var game = new Game()
            {
                Board =  new Board(1,1),
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(1,0)
                },
                Turtle = new Turtle()
                {
                    Actions = actions,
                    StartPosition = new Position()
                    {
                        Direction = Direction.N,
                        Position = new Point(0,1)
                    }
                },
                Mines = mines
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            mineEscape.Play();
            
            Assert.True(game.Turtle.CurrentPosition.Direction == Direction.N);
        }
        
        
        [Fact]
        public void WhenGameHasInvalidBoard()
        {
            // Arrange
            var game = new Game();
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            try
            {
                mineEscape.Play();
            }
            catch (BusinessException e)
            {
                Assert.True(e.Message == "Board invalid");
            }

        }
        
        [Fact]
        public void WhenGameHasInvalidTurtle()
        {
            // Arrange
            var game = new Game()
            {
                Board =  new Board(1,1)
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            try
            {
                mineEscape.Play();
            }
            catch (BusinessException e)
            {
                Assert.True(e.Message == "Turtle does not have any move");
            }
        }
        
        [Fact]
        public void WhenGameHasNotExitPosition()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            var game = new Game()
            {
                Board =  new Board(1,1),
                Turtle = new Turtle()
                {
                    Actions = actions
                }
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            try
            {
                mineEscape.Play();
            }
            catch (BusinessException e)
            {
                Assert.True(e.Message == "Exit position invalid");
            }
        }
        
        [Fact]
        public void WhenGameHasInvalidExitPosition()
        {
            // Arrange
            var actions = new List<TurtleAction>();
            actions.Add(TurtleAction.L);
            var game = new Game()
            {
                Board =  new Board(1,1),
                Turtle = new Turtle()
                {
                    Actions = actions
                },
                ExitPoint = new ExitPoint()
                {
                    Position = new Point(-1,-1)
                }
            };
            var results = new List<Result>();
            var mineEscape = new MineScape(game, results);
            
            // Assert
            try
            {
                mineEscape.Play();
            }
            catch (BusinessException e)
            {
                Assert.True(e.Message == "Exit position invalid");
            }
        }
    }
}