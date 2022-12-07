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

                if(!IsCellsAroundOcpied(cellX, cellY, actualShipIndex, cells))
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

                if (!IsCellsAroundOcpied(cellY, cellX, actualShipIndex, cells))
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

    }
}
