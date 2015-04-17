using System;
using Roluan.Emulator.Board.Components.BiosComponent;
using Roluan.Emulator.Board;

namespace Roluan.Emulator
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            new MainBoard().PowerUp();
        }
    }
}