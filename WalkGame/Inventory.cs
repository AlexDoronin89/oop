using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkGame
{
    class Inventory
    {
       public char[] Inventary;
        public int InventY=10;
        public int WinMessY=15;
        

        public Inventory(char[] inventary)
        {
            Inventary = inventary;
            
        }

        public Inventory(int inventY, int winMessY)
        {
            InventY = inventY;
            WinMessY = winMessY;
        }
    }
}
