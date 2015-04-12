using System.Collections.Generic;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Board.Registers
{
    public class InterruptsRegister : RegisterBase
    {
        
        public InterruptsRegister()
        {
            Initialize();
        }


        private void Initialize()
        {
            Trits = new List<Trit>();
            for (int i = 0; i < Config.INTERRUPTS_REGISTER_SIZE * Config.TRYTE_SIZE; i++)
            {
                Trits.Add(new Trit { });
            }
        }
    }
}