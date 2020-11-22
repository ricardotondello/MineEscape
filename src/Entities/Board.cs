using System.Collections.Generic;
using System.Drawing;

namespace Entities
{
    public class Board
    {
        public string[,] Minefield { get; set; }
        
        public Board(int n, int m)
        {
            Minefield = new string[n, m];
        }
    }
    
}