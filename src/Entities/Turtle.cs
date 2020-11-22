using System;
using System.Collections.Generic;
using Utils;

namespace Entities
{
    public class Turtle
    {
        private Position _startPosition;
        public Position CurrentPosition { get; set; }

        public Position StartPosition
        {
            get => _startPosition;
            set
            {
                _startPosition = value;
                CurrentPosition = new Position()
                {
                    Direction = _startPosition.Direction,
                    Position = _startPosition.Position
                };
            }
        }

        public List<Move> Moves { get; set; }

        public void ResetTurtle()
        {
            CurrentPosition = CurrentPosition = new Position()
            {
                Direction = StartPosition.Direction,
                Position = StartPosition.Position
            };
        }
        public void DoRotate(TurtleAction action)
        {
            var newPosition = CurrentPosition;
            var direction = (int) CurrentPosition.Direction + (int) action;
            if (direction == 360) direction = 0;
            if (direction < 0) direction += 360;
            
            newPosition.Direction = (Direction) direction;
            
            CurrentPosition = newPosition;
        }
    }
}