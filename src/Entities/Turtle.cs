using System.Collections.Generic;

namespace Entities
{
    public class Turtle
    {
        private Position _startPosition;
        public Position CurrentPosition { get; set; }

        public Position StartPosition
        {
            set
            {
                _startPosition = value;
                CurrentPosition = value;
            }
        }

        public List<TurtleAction> Actions { get; set; }

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