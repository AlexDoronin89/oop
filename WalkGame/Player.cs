using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkGame
{
    class Players
    {
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;
        
        public char S1;
        public char S2;
        public ConsoleColor Color;

        public Players( int playerX1, int playerY1, int playerX2, int playerY2, char playerS1, char playerS2, ConsoleColor color)
        {
            X1 = playerX1;
            Y1 = playerY1;
            X2 = playerX2;
            Y2 = playerY2;
            
            S1 = playerS1;
            S2 = playerS2;
            Color = color;
        }
       
    }
}
