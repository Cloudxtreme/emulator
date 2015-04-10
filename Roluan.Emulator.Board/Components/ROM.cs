using Roluan.Emulator.Board.Registers;

namespace Roluan.Emulator.Board.Components
{
    public class ROM
    {
        public SymbolsRegister SymbolsRegister { get; private set; }

        public InterruptsRegister InterruptsRegister { get; private set; }

        public ROM()
        {
            SymbolsRegister = new SymbolsRegister();
            InterruptsRegister = new InterruptsRegister();
        }
    }
}
