using Roluan.Board.Base.Registers;
using Roluan.Common;
using Roluan.Common.Base;
using System.Collections.Generic;

namespace Roluan.Emulator.Board.Registers
{
    public class InterruptsRegister : RegisterBase
    {
        
        public InterruptsRegister()
        {
            this.Name = "InterruptsRegister";
            InitializeTrytes();
        }


        private void InitializeTrytes()
        {
            Interrupt Interrupt = new Interrupt();
            Trits = new List<Trit>();
            for (int i = 0; i < Config.INTERRUPTS_REGISTER_SIZE * 9; i++)
            {
                Trits.Add(new Trit { });
            }
        }

    }
}