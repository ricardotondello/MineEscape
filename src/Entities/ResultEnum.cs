using System.ComponentModel;

namespace Entities
{
    public enum ResultEnum
    {
        [Description("Success")]
        Success,
        
        [Description("Mine Hint")]
        MineHit,
        
        [Description("Still in Danger")]
        InDanger
    }
}