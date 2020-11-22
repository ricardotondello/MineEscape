using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Entities;

namespace MineEscape
{
    public class MineScape
    {
        private readonly Game _game;

        private readonly List<Result> _results;
        public MineScape(Game game, List<Result> results)
        {
            _game = game;
            _results = results;
        }
        
        public void Play()
        {
            ValidateGame();
            Console.WriteLine("Game started...");
            
            foreach (var move in _game.Turtle.Actions)
            {
                var result = _game.MoveTurtle(move);
                _results.Add(result);
                Console.WriteLine(result.Message);
                
                if (result.IsSome) break;
            }
            
            Console.WriteLine("End of game...");
        }

        private void ValidateGame()
        {
            if ((_game.Board == null) || (_game.Board.Minefield.Length <= 0)) throw new BusinessException("Board invalid");
            if ((_game.Turtle == null) || (!_game.Turtle.Actions.Any())) throw new BusinessException("Turtle does not have any move");
            if ((_game.ExitPoint == null) || ((_game.ExitPoint.Position.X < 0) || (_game.ExitPoint.Position.Y < 0))) throw  new BusinessException("Exit position invalid"); 
        }
    }
}