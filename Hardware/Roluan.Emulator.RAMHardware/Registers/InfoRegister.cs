using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.RAMHardware.Registers
{
    public class InfoRegister: RegisterBase
    {
        public InfoRegister()
        {
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i <= 243; i++)
            {
                Trits.Add(new Trit{ State = TritState.Zero });
            }
        }
    }
}