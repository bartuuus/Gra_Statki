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
    public partial class MyGameForm : Form
    {
        public MyGameForm()
        {
            InitializeComponent();
        }

        private void PbPlayerBoard_Paint(object sender, PaintEventArgs e)
        {
            Drawing.DrawPlacedCells(Game.PlayerOne.Board, e);
            Drawing.DrawCells(Game.PlayerOne.HittedFields, Game.PlayerOne.Board, e);
        }
        int mouseX;
        int mouseY;
        private void PbComputerBoard_MouseMove(object sender, MouseEventArgs e)
        {
            
            mouseX = Coordinates.GetCell(Coordinates.GetX(this, pbComputerBoard));
            mouseY = Coordinates.GetCell(Coordinates.GetY(this, pbComputerBoard));

            pbComputerBoard.Refresh();

            Drawing.DrawFrame(mouseX, mouseY, 4, pbComputerBoard);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int[] computerMove = Game.ComputerAttack(Game.PlayerOne);

            if(!Game.PerformAttack(computerMove[0], computerMove[1], Game.ComputerPlayer, Game.PlayerOne))
            {
                timerComputerMove.Stop();
                pbComputerBoard.Enabled = true;

                mouseX = Coordinates.GetCell(Coordinates.GetX(this, pbComputerBoard));
                mouseY = Coordinates.GetCell(Coordinates.GetY(this, pbComputerBoard));


                pbComputerBoard.Refresh();
                Drawing.DrawFrame(mouseX, mouseY, 4, pbComputerBoard);
            }
            pbPlayerBoard.Refresh();
        }

        private void PbComputerBoard_Click(object sender, EventArgs e)
        {
            mouseX = Coordinates.GetCell(Coordinates.GetX(this, pbComputerBoard));
            mouseY = Coordinates.GetCell(Coordinates.GetY(this, pbComputerBoard));

            if(!Game.ComputerPlayer.HittedFields[mouseX, mouseY])
            {
                if(Game.PerformAttack(mouseX, mouseY, Game.PlayerOne, Game.ComputerPlayer))
                {
                    pbComputerBoard.Refresh();
                    if (Game.ComputerPlayer.ShipCountToDestroy == 0)
                    {
                        Game.EndGame(Game.ComputerPlayer);
                    }
                }
                else
                {
                    pbComputerBoard.Refresh();
                    pbComputerBoard.Enabled = false;
                    timerComputerMove.Start();
                    if (Game.ComputerPlayer.ShipCountToDestroy == 0)
                    {
                        Game.EndGame(Game.ComputerPlayer);
                    }
                }
            }

        }

        private void PbComputerBoard_Paint(object sender, PaintEventArgs e)
        {
            Drawing.DrawKilledShip(Game.ComputerPlayer.Board, Game.ComputerPlayer.Fleet, e);
            Drawing.DrawCells(Game.ComputerPlayer.HittedFields, Game.ComputerPlayer.Board, e);
        }

        private void MyGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
