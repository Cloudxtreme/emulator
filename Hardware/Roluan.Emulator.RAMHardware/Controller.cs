using System.Collections.Generic;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.RAMHardware.Registers;

namespace Roluan.Emulator.RAMHardware
{
    public class Controller : IController
    {
        public Controller()
        {
            Initialize();
        }

        List<RegisterBase> registers = new List<RegisterBase>();

        public IDriver Driver
        {
            get
            {
                return new Driver();
            }
        }

        public IList<RegisterBase> Registers
        {
            get
            {
                return registers;
            }
        }

        void Initialize()
        {
            Registers.Add(new InfoRegister());
        }
    }
}