using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Statki.Classes
{
    public static class Game
    {
        public static Player PlayerOne { get; set; }
        public static Player ComputerPlayer { get; set; }

        public static int[] ShipsSize = new int[] { 1, 2, 3, 4 };

        static int LastBoardIndex => Player.BoardSize - 1;

        public static bool CanShipBePlaced(int actualShipIndex, int cellX, int cellY, bool horizontally, int[,] cells)
        {
            if(!IsInBoard(cellX, cellY))
            {
                return false;
            }

            if (horizontally)
            {
                if(!CanFitInBoard(cellX, actualShipIndex))
                {
                    return false;
                }

                if(IsCellsAroundOcpied(cellX, cellY, actualShipIndex, cells))
                {
                    return false;
                }
            }
            else
            {
                if (!CanFitInBoard(cellY, actualShipIndex))
                {
                    return false;
                }

                if (IsCellsAroundOcpied(cellY, cellX, actualShipIndex, cells))
                {
                    return false;
                }
            }
            return true;
            
        }

        public static bool IsCellsAroundOcpied(int cellFirst, int cellSecond, int actualShipIndex, int[,] cells)
        {
            for (int i = Math.Max(0, cellFirst - 1); i <= Math.Min(LastBoardIndex, cellFirst + Game.ShipsSize[actualShipIndex]); i++)
            {
                for (int j = Math.Max(0, cellSecond); j <= Math.Min(LastBoardIndex, cellSecond + 1); j++)
                {
                    if (IsCellOcupied(cells, i, j))
                    {
                        return true;
                    }
                  
                }
            }
            return false;
        }

        public static bool IsCellOcupied(int[,] cells, int i, int j)
        {
            if(cells[i,j]!= -1)
            {
                return true;
            }
            return false;

        }
        public static bool CanFitInBoard(int cell, int actualShipIndex)
        {
            if(cell + Game.ShipsSize[actualShipIndex] - 1 <= Player.BoardSize - 1)
            {
                return true;
            }
            return false; 
        }

        public static bool IsInBoard(int cellX, int cellY)
        {
            if(cellX < 0 || cellY < 0)
            {
                return false;
            }
            return true;
        }

        public static void SetShip(int actualShipIndex, int mouseX, int mouseY, bool horizontally, int[,] board)
        {
            if (horizontally)
            {
                for(int i =0; i < Game.ShipsSize[actualShipIndex]; i++)
                {
                    board[mouseX + i, mouseY] = actualShipIndex;
                }
            }
            else
            {
                for (int i = 0; i < Game.ShipsSize[actualShipIndex]; i++)
                {
                    board[mouseX, mouseY + i] = actualShipIndex;
                }
            }
        }

        public static void SetComputerShips()
        {
            Random random = new Random();
            for(int shipIndex = 0; shipIndex < ShipsSize.Length;)
            {
                int x = random.Next(Player.BoardSize);
                int y = random.Next(Player.BoardSize);

                if(CanShipBePlaced(shipIndex, x, y, true, Game.ComputerPlayer.Board))
                {
                    SetShip(shipIndex, x, y, true, Game.ComputerPlayer.Board);
                    shipIndex++;
                }
            }
        }
        public static bool PerformAttack(int x, int y, Player attacker , Player defender)
        {
            defender.HittedFields[x, y] = true;
            if (defender.Board[x, y] != -1)
            {
                defender.Fleet[defender.Board[x, y]]--;
                if (defender.Fleet[defender.Board[x, y]] == 0)
                {
                    defender.ShipCountToDestroy--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int[] ComputerAttack(Player player)
        {
            Random r = new Random();
            int x = r.Next(0, 9);
            int y = r.Next(0, 9);

            while (player.HittedFields[x, y] == true)
            {
                x = r.Next(0, 9);

                y = r.Next(0, 9);
            }
            return new int[] { x, y };
        }
        
       
    }
}
