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


    }
}
