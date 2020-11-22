using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Entities
{
    public class Game
    {
        public Board Board { get; set; }
        public List<Mine> Mines { get; set; } = new List<Mine>();
        public ExitPoint ExitPoint { get; set; }
        public Turtle Turtle { get; set; }
        
        public Result MoveTurtle(TurtleAction action)
        {
            Turtle.DoRotate(action);

            var position = this.DoMove(action);
            
            if (IsHitByAMine(position)) return  Result.MineHit();
            
            return ExitHasBeenFind(position) ? Result.Success() : Result.StillInDanger();
        }

        private Position DoMove(TurtleAction action)
        {
            if (action != TurtleAction.M) return Turtle.CurrentPosition;
            
            var position = Turtle.CurrentPosition;
            var x = 0;
            var y = 0;

            switch (position.Direction)
            {
                case Direction.E:
                    y += 1;
                    break;
                case Direction.W:
                    y -= 1;
                    break;
                case Direction.N:
                    x -= 1;
                    break;
                case Direction.S:
                    x += 1;
                    break;
            }

            var p = new Point( position.Position.X + x, position.Position.Y + y );
            position.Position = p;
            return position;
        }
        
        private bool IsHitByAMine(Position position)
        {
            return Mines.Any(x => x.Position == position.Position);
        }

        private bool ExitHasBeenFind(Position position)
        {
            return ExitPoint.Position == position.Position;
        }
    }
}