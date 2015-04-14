using System;
using Roluan.Emulator.Board.Components.BiosComponent;

namespace Roluan.Emulator
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            new Bios();
        }
    }
}