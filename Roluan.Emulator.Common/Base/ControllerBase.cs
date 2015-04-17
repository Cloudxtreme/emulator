namespace Roluan.Emulator.Common.Base
{
    public abstract class ControllerBase
    {
        readonly ControllerRegisters registers = new ControllerRegisters();

        public ControllerRegisters Registers
        { 
            get
            { 
                return registers;
            }
        }

        public abstract DriverBase Driver { get; }
    }
}