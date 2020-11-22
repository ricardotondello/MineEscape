using System.ComponentModel;

namespace Entities
{
    public enum TurtleAction
    {
        [Description("Rotate 90 degrees to the right")]
        R = 90,
        
        [Description("Rotate 90 degrees to the left")]
        L = -90,
        
        [Description("Move")]
        M = 0
    }
}