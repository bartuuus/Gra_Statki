using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Statki.Classes
{
    public class Player
    {
        public int[,] Board { get; set; }
        public bool[,] HittedFields { get; set; }
        public int[] Fleet { get; set; }
        public int ShipCountToDestroy { get; set; }
        public static int BoardSize => 10;
        public string PlayerName { get; set; }
        public Player()
        {
            Fleet = new int[] { 1, 2, 3, 4 };
            Board = new int[BoardSize, BoardSize];
            HittedFields = new bool[BoardSize, BoardSize];
            ShipCountToDestroy = Fleet.Length;

            Initialize(Board, HittedFields);
           
        }

        private void Initialize(int[,] board, bool[,] hittedFields)
        {
            for(int i = 0; i<BoardSize; i++)
            {
                for(int j = 0; j<BoardSize; j++)
                {
                    board[i, j] = -1;
                    hittedFields[i, j] = false;
                }
            }
        }
    }
}
