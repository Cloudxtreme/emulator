using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Interfaces;
using Roluan.Monitor.Driver;
using System.Collections.Generic;

namespace Roluan
{
    public class Driver : IMonitorDriver
    {
        public bool Initialize(IMonitorHardware hardwareInstance)
        {
            try
            {
                List<Resolution> SupportedResolutions = new List<Resolution>();
                SupportedResolutions.Add(new Resolution() { Height = 500, Width = 800 });
                SupportedResolutions.Add(new Resolution() { Height = 400, Width = 640 });
                SupportedResolutions.Add(new Resolution() { Height = 640, Width = 1024 });

                MonitorRegister.Instance = new MonitorRegister();
                MonitorRegister.Instance.Name = "Monitor";
                MonitorRegister.Instance.Trits.Add(new Trit());
                this.Instance = MonitorRegister.Instance;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public RegisterBase Instance { get; set; }

        public List<Resolution> Resolutions
        {
            get;
            set;
        }
    }
}

