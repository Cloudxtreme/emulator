using Roluan.Common;
using System.Collections.Generic;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common;

namespace Roluan.Emulator.Board.Registers
{
    public class InterruptsRegister : RegisterBase
    {
        
        public InterruptsRegister()
        {
            InitializeTrytes();
        }


        private void InitializeTrytes()
        {
            Trits = new List<Trit>();
            for (int i = 0; i < Config.INTERRUPTS_REGISTER_SIZE * 9; i++)
            {
                Trits.Add(new Trit { });
            }
        }
    }
}