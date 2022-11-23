using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Statki.Classes
{
    public static class Coordinates
    {
        public static int GetX(Form form, PictureBox pictureBox)
        {
            int windowFrame = (form.Width - form.ClientSize.Width) / 2;
            int x = Control.MousePosition.X - form.Location.X - pictureBox.Location.X - windowFrame;
            return x;
        }
        public static int GetY(Form form, PictureBox pictureBox)
        {
            int windowFrame = (form.Width - form.ClientSize.Width) / 2;
            int titleBarHeight = form.Height - form.ClientSize.Height - 2 * windowFrame;

            int y = Control.MousePosition.Y - form.Location.Y - pictureBox.Location.Y - titleBarHeight - windowFrame;
            return y;
        }
        public static int GetCell(int cord)
        {
            int cell = cord / 40;
            if (cell >= 0 && cell <= 9)
            {
                return cell;
            }
            return -1;
        }
    }
}
