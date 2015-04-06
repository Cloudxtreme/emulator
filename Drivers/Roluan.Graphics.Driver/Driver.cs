using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
using Roluan.Graphics.Driver;

namespace Roluan
{
    public class Driver : IGraphicDriver
    {

        public bool Initialize(IGraphicHardware hardwareInstance)
        {
            try
            {

                GraphicRegister.Instance = new GraphicRegister();
                GraphicRegister.Instance.Name = "Graphic";
                GraphicRegister.Instance.Trits.Add(new Trit());
                this.Instance = GraphicRegister.Instance;

                if (CurrentResolution != null && CurrentColorScheme != null)
                {

                    TritMap = new List<Trit>();
                    for (int i = 0; i < CurrentResolution.Height * CurrentResolution.Width * CurrentColorScheme.Size; i++)
                    {
                        TritMap.Add(new Trit());
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public RegisterBase Instance { get; set; }

        public List<Trit> TritMap { get; set; }

        public Resolution CurrentResolution
        {
            get;
            set;
        }

        public ColorScheme CurrentColorScheme
        {
            get;
            set;
        }


        public List<Resolution> Resolutions
        {
            get;
            set;
        }

        public List<ColorScheme> ColorSchemes
        {
            get;
            set;
        }
    }
}
