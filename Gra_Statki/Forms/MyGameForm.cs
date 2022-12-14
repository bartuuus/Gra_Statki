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
        }
        int mouseX;
        int mouseY;
        private void PbComputerBoard_MouseMove(object sender, MouseEventArgs e)
        {
            
            mouseX = Coordinates.GetCell(Coordinates.GetX(this, pbComputerBoard));
            mouseY = Coordinates.GetCell(Coordinates.GetX(this, pbComputerBoard));

            pbComputerBoard.Refresh();

            Drawing.DrawFrame(mouseX, mouseY, 4, pbComputerBoard);
        }
    }
}
