using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roluan.Emulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //var board = Roluan.Board.Board.Instance.RAM;
            //var keyBoard = Roluan.Board.Board.Instance.Keyboard;
            //var mouse = Roluan.Board.Board.Instance.Mouse;
            //var video = Roluan.Board.Board.Instance.Graphic;
            //var monitor = Roluan.Board.Board.Instance.Monitor;

            var board = Roluan.Board.Board.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen(board.Graphic.TritMap, board.Graphic.CurrentResolution, board.Graphic.CurrentColorScheme));
        }
    }

}

