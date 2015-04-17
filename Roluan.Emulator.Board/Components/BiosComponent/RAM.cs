using System;

namespace Roluan.Emulator.Board.Components.BiosComponent
{
    public class RAM
    {
        public DevicesRegister DevicesRegister { get; private set; }

        public RAM()
        {
            DevicesRegister = new DevicesRegister();
        }
    }
}