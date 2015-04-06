using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Interfaces;
using Roluan.RAM.Driver;

namespace Roluan
{
    public class Driver : IRAMDriver
    {
        public bool Initialize(IRAMHardware hardwareInstance)
        {
            try
            {
                RAMRegister.Instance = new RAMRegister();
                RAMRegister.Instance.Name = "RAM";
                for (int i = 0; i < hardwareInstance.Size; i++)
                {
                    RAMRegister.Instance.Trits.Add(new Trit());
                }
                this.Instance = RAMRegister.Instance;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public RegisterBase Instance { get; set; }

    }
}
