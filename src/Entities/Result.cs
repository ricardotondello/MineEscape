using Utils;

namespace Entities
{
    public class Result
    {
        public bool IsSome { get; }
        public string Message { get; }

        private Result(ResultEnum resultEnum)
        {
            this.IsSome = resultEnum == ResultEnum.Success;
            this.Message = resultEnum.ToDescriptionString();
        }
        
        public static Result Success() => new Result(ResultEnum.Success);
        public static Result MineHit() => new Result(ResultEnum.MineHit);
        public static Result StillInDanger () => new Result(ResultEnum.InDanger);

    }
}