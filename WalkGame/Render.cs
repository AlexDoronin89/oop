using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkGame
{
    class Render
    {
        Players Players;
        Inventory Inventory;
        
        public Render(Inventory inventory)
        {
            Inventory = inventory;
        }

        
        
        

        
        

        

        public Render(Players players)
        {
            Players = players;
        }

        

        public void DrawPlayer1()
        {
            Console.SetCursorPosition(Players.X1, Players.Y1);
            Console.Write(Players.S1);
        }

        public void DrawPlayer2()
        {
            Console.SetCursorPosition(Players.X2, Players.Y2);
            Console.Write(Players.S2);
        }

        public void PrintInvent(int posY)
        {
            Console.SetCursorPosition(0,posY);
            Console.Write("inv");
            for (int i = 0; i < Inventory.Inventary.Length; i++)
            {
                Console.Write(Inventory.Inventary[i] + " ");
            }
        }

       

        public void addItem1(char[,] map, int playerX1, int playerY1)
        {
            char[] tempArray = new char[Inventory.Inventary.Length + 1];
            for (int i = 0; i < Inventory.Inventary.Length; i++)
            {
                tempArray[i] = Inventory.Inventary[i];

            }
            Inventory.Inventary = tempArray;
            Inventory.Inventary[Inventory.Inventary.Length - 1] = map[playerY1, playerX1];

            map[playerY1, playerX1] = ' ';
        }

        public void addItem2(char[,] map , int playerX2, int playerY2)
        {
            char[] tempArray = new char[Inventory.Inventary.Length + 1];
            for (int i = 0; i < Inventory.Inventary.Length; i++)
            {
                tempArray[i] = Inventory.Inventary[i];

            }
            Inventory.Inventary = tempArray;
            Inventory.Inventary[Inventory.Inventary.Length - 1] = map[playerY2, playerX2];

            map[playerY2, playerX2] = ' ';
        }

       
        public void Move1(char[,] map)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Console.SetCursorPosition(Players.X1, Players.Y1);
            Console.Write(' ');
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (map[Players.Y1 - 1, Players.X1] != '#')
                    {
                        Players.Y1--;
                    }
                    break;
                case ConsoleKey.A:
                    if (map[Players.Y1, Players.X1 - 1] != '#')
                    {
                        Players.X1--;
                    }
                    break;
                case ConsoleKey.S:
                    if (map[Players.Y1 + 1, Players.X1] != '#')
                    {
                        Players.Y1++;
                    }
                    break;
                case ConsoleKey.D:
                    if (map[Players.Y1, Players.X1 + 1] != '#')
                    {
                        Players.X1++;
                    }
                    break;


            }
        }
        public void Move2(char[,] map)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Console.SetCursorPosition(Players.X2, Players.Y2);
            Console.Write(' ');
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[Players.Y2 - 1, Players.X2] != '#')
                    {
                        Players.Y2--;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[Players.Y2, Players.X2 - 1] != '#')
                    {
                        Players.X2--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[Players.Y2 + 1, Players.X2] != '#')
                    {
                        Players.Y2++;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[Players.Y2, Players.X2 + 1] != '#')
                    {
                        Players.X2++;
                    }
                    break;
            }
        }
    }
}
