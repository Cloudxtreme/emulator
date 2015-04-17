using Roluan.Emulator.Board.Components.BiosComponent;

namespace Roluan.Emulator.Board.Components.Bus
{
    public class SouthBridge
    {
        public Bios Bios { get; private set;}

        public SouthBridge()
        {
            Bios = new Bios();
        }
    }
}