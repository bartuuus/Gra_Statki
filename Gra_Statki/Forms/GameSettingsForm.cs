using Gra_Statki.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Statki.Forms
{
    public partial class GameSettingsForm : Form
    {
        const int OUT_OF_BOUND = -1;

        int mouseX;
        int mouseY;
        int actualShipIndex;
        bool horizontally;
        bool[] settedShips = new bool[4];
        bool mouseOnBoard;
        int lastBoardIndex = Player.BoardSize - 1;




         public GameSettingsForm()
         {
            InitializeComponent();
            horizontally = true;
            Game.PlayerOne = new Player();
            Game.ComputerPlayer = new Player();
            actualShipIndex = 0;

            lblPlayerName.Visible = false;
            btnNext.Enabled = false;

            
         }
                                                              
        private void PbPlayerBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (actualShipIndex >= 4 || !IsMouseOnBoard())
            {
                return;
            }



            mouseX = Coordinates.GetCell(Coordinates.GetX(this, pbPlayerBoard));
           mouseY = Coordinates.GetCell(Coordinates.GetY(this, pbPlayerBoard));
           mouseOnBoard = mouseX != -1 && mouseY != -1;

           if (!mouseOnBoard) { return; }
           
            pbPlayerBoard.Refresh();


            if (horizontally)
            {
                for(int i = 0; i<Game.ShipsSize[actualShipIndex]; i++)
                {

                   if(mouseX + i > lastBoardIndex)
                   {
                       break;
                   }
                    
                        Drawing.DrawFrame(mouseX + i, mouseY, actualShipIndex, pbPlayerBoard);
                    
                }
              return;
            }
            
          
            for (int i = 0; i< Game.ShipsSize[actualShipIndex]; i++)
            {
               if(mouseY + 1 > lastBoardIndex) { break; }

                Drawing.DrawFrame(mouseX, mouseY + i, actualShipIndex, pbPlayerBoard);
               
            }
          
          
        }

        private bool IsMouseOnBoard()
        {
            if (mouseX != OUT_OF_BOUND || mouseY != OUT_OF_BOUND)
            {
                mouseX = OUT_OF_BOUND;
                mouseY = OUT_OF_BOUND;
                pbPlayerBoard.Refresh();
                return false;
            }
            return true;
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            horizontally = !horizontally;
        }

        

        private void PbPlayerBoard_Click(object sender, EventArgs e)
        {
            if (!IsMouseOnBoard())
            {
                return;
            }
            if (!Game.CanShipBePlaced(actualShipIndex, mouseX, mouseY, horizontally, Game.PlayerOne.Board))
            {
                return;
            }

            settedShips[actualShipIndex] = true;
            Game.SetShip(actualShipIndex, mouseX, mouseY, horizontally, Game.PlayerOne.Board);
            pbPlayerBoard.Refresh();
            if (actualShipIndex < Game.ShipsSize.Length)
            {
                actualShipIndex++;
            }

            if (AreAllShipsPlaced())
            {
                btnNext.Enabled = true;
            }

        }

        private bool AreAllShipsPlaced()
        {
            foreach(var ship in settedShips)
            {
                if(ship!= true)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
