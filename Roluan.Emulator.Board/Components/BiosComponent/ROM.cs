namespace Roluan.Emulator.Board.Components.BiosComponent
{
    public class ROM
    {
        public SymbolsRegister SymbolsRegister { get; private set; }

        public ROM()
        {
            SymbolsRegister = new SymbolsRegister();
        }
    }
}
