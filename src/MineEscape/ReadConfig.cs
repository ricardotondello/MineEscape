using System;
using System.Collections.Generic;
using System.Drawing;
using Entities;

namespace MineEscape
{
    public class ReadConfig
    {
        private readonly string[] _lines;
        private const string SpaceSeparator = " ";
        private const string ComaSeparator = ",";
        public ReadConfig(string[] lines)
        {
            _lines = lines;
        }
        public Game Read()
        {
            var board = GetBoard(_lines[0]);
            
            var mines = GetMines(_lines[1]);

            var exitPoint = GetExitPoint(_lines[2]);
            
            var turtle = GetTurtle(_lines);

            return new Game()
            {
                Board = board, 
                Mines = mines, 
                ExitPoint = exitPoint, 
                Turtle = turtle
            };
            }

            private static Board GetBoard(string line)
            {
                var sizeStrings = line.Split(SpaceSeparator);
                int.TryParse(sizeStrings[0], out var sizeN);
                int.TryParse(sizeStrings[1], out var sizeM);

                return new Board(sizeN, sizeM);
            }

            private static List<Mine> GetMines(string line)
            {
                var mines = new List<Mine>();
                
                var minesStrings = line.Split(SpaceSeparator);
                foreach (var t in minesStrings)
                {
                    int.TryParse(t.Split(ComaSeparator)[0], out var mineX);
                    int.TryParse(t.Split(ComaSeparator)[1], out var mineY);
                    mines.Add(new Mine()
                    {
                        Position = new Point(mineX, mineY)
                    });
                }
                return mines;
            }
            
            private static Turtle GetTurtle(IReadOnlyList<string> lines)
            {
                var startPositionStrings = lines[3].Split(SpaceSeparator);
                int.TryParse(startPositionStrings[0], out var posX);
                int.TryParse(startPositionStrings[1], out var posY);
                Enum.TryParse(startPositionStrings[2], out Direction direction);
                
                var turtleMoves = new List<Move>(); 
                for (var i = 4; i < lines.Count; i++)
                {
                    var moves = new Move();
                    // var actions = new List<TurtleAction>();
                    var movesString = lines[i].Split(SpaceSeparator);
                    foreach (var moveString in movesString)
                    {
                        Enum.TryParse(moveString, out TurtleAction move);
                        // actions.Add(move);
                        moves.Actions.Add(move);
                    }
                    turtleMoves.Add(moves);
                }
                
                return new Turtle()
                {
                    StartPosition = new Position() 
                    { 
                        Position = new Point(posX, posY), 
                        Direction = direction
                    },
                    Moves = turtleMoves
                };
            }
            
            private static ExitPoint GetExitPoint(string line)
            {
                var exitPointStrings = line.Split(SpaceSeparator);
                int.TryParse(exitPointStrings[0], out var exitX);
                int.TryParse(exitPointStrings[1], out var exitY);
                return new ExitPoint() {Position = new Point(exitX, exitY)};
            }
        
        
    }
}