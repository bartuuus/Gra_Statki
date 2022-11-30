using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Statki.Classes
{
    public static class Drawing
    {
        private static readonly Bitmap hitImage = Properties.Resources.hitImage;
        private static readonly Bitmap splashImage = Properties.Resources.splashImage;

        private static int Transparency { get; set; } = 255;

        public static readonly Brush[] Colors = new SolidBrush[5]
        {
            new SolidBrush(Color.FromArgb(Transparency, Color.Gold)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Green)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Blue)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Red)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Violet)),
        };

        const int FRAME_WIDTH = 35;
        const int FRAME_HEIGHT = 35;
        const int CELL_WIDTH = 40;
        const int CELL_HEIGHT = 40;
        public static void DrawFrame(int cellX, int cellY, int color, PictureBox pb)
        {
            Graphics graph = pb.CreateGraphics();

            var pen = new Pen(Drawing.Colors[color], 3);
            graph.DrawRectangle(pen, cellX * CELL_WIDTH, cellY * CELL_HEIGHT, FRAME_WIDTH, FRAME_HEIGHT);
        }

    }
}
