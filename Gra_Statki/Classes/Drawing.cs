using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Statki.Classes
{
    public static class Drawing
    {
        private static readonly Bitmap hitImage = Properties.Resources.hitImage;
        private static readonly Bitmap splashImage = Properties.Resources.splashImage;

        private static int Transparency { get; set; } = 255;

        public static readonly Brush[] Colors = new SolidBrush[5]
        {
            new SolidBrush(Color.FromArgb(Transparency, Color.Yellow)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Green)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Blue)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Red)),
            new SolidBrush(Color.FromArgb(Transparency, Color.Violet)),
        };
    }
}
