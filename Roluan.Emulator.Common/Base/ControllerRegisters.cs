using System.Collections.Generic;

namespace Roluan.Emulator.Common.Base
{
    public class ControllerRegisters: List<RegisterBase>
    {
        public ControllerRegisters()
        {
            Add(new InfoRegister());
        }
    }
}