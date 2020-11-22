using System.Collections.Generic;

namespace Entities
{
    public class Move
    {
        public List<TurtleAction> Actions { get; set; } = new List<TurtleAction>();
    }
}