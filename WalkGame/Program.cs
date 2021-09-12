using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Players players =new Players(1, 1, 4, 5,'R','L',ConsoleColor.Red);
            Render render = new Render(players);
            Inventory inventory = new Inventory(new char[0]);
            Render render1 = new Render(inventory);
           
            int goldcount = 7;
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','$',' ',' ',' ','$','#'},
                {'#',' ','#','#',' ','#','#','#',' ','#'},
                {'#',' ','#','#',' ','#','#','#',' ','#'},
                {'#',' ',' ',' ','$',' ',' ',' ','$','#'},
                {'#',' ','#','#',' ','#','#','#',' ','#'},
                {'#',' ','#','#',' ','#','#','#',' ','#'},
                {'#',' ','#','#',' ','#','#','#',' ','#'},
                {'#','$',' ',' ','$',' ',' ',' ','$','#'},
                {'#','#','#','#','#','#','#','#','#','#'},
            };
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == '$')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(map[i, j]);
                    Console.ForegroundColor=ConsoleColor.White;
                }
                Console.WriteLine();
            }
            while (inventory.Inventary.Length < goldcount)
            {
                render.DrawPlayer1();
                render.Move1(map);
                if(map[players.X1,players.Y1]== '$')
                {
                    render1.addItem1(map, players.X1, players.Y1);
                }
                if (map[players.X2, players.Y2] == '$')
                {
                    render1.addItem2(map, players.X2, players.Y2);
                }
                render1.PrintInvent(inventory.InventY);
                render.DrawPlayer2();
                render.Move2(map);
                if (map[players.X2, players.Y2] == '$')
                {
                    render1.addItem2(map, players.X2, players.Y2);
                }
                render1.PrintInvent(inventory.InventY);
               


            }
            Console.SetCursorPosition(0, inventory.WinMessY);
            Console.WriteLine("WIN");
            Console.ReadKey();
        }

        

        

        

       
    }
    

}
