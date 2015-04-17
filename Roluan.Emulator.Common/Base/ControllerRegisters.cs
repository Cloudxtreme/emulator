namespace Roluan.Emulator.Common.Base
{
    public class ControllerRegisters
    {
        readonly InfoRegister infoRegister = new InfoRegister();

        public InfoRegister InfoRegister
        {
            get
            { 
                return infoRegister;
            }
        }
    }
}