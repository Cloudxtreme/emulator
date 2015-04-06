using Roluan.Common.Base;
using Roluan.Common.Interfaces;
using System.Collections.Generic;

namespace Roluan.Board
{
    public class Board
    {
        private static Board instance;
        private static Bios bios = null;

        public IRAMDriver RAM { get; set; }
        public IKeyboardDriver Keyboard { get; set; }
        public IMouseDriver Mouse { get; set; }
        public IGraphicDriver Graphic { get; set; }
        public IMonitorDriver Monitor { get; set; }
        public IInterruptDriver Interrupt { get; set; }
        public static Board Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Board();
                    bios = new Bios();
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }
}