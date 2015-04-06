using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
using Roluan.Mouse.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roluan
{
    public class Driver : IMouseDriver
    {
        public bool Initialize(IMouseHardware hardwareInstance)
        {
            try
            {
                Task task = new Task(InitializeKeys);
                task.Start();
                MouseRegister.Instance = new MouseRegister();
                MouseRegister.Instance.Name = "Mouse";
                MouseRegister.Instance.Trits.Add(new Trit());
                this.Instance = MouseRegister.Instance;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Tryte> MouseAction { get; set; }

        public RegisterBase Instance { get; set; }

        public async void InitializeKeys()
        {
            var mouseActions = new List<Tryte>();

            mouseActions.Add(new Tryte());
            mouseActions.Add(new Tryte());
            mouseActions.Add(new Tryte());

            this.MouseAction = mouseActions;
        }
    }
}
