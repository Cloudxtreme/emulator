using System.Collections.Generic;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Board.Components.BiosComponent
{
    public class DevicesRegister: RegisterBase
    {
        public DevicesRegister()
        {
            Initialize();
        }

        void Initialize()
        {
            Trits = new List<Trit>();
            
            for (int i = 0; i < 243; i++)
            {
                Trits.Add(new Trit{ State = TritState.Zero });
            }
        }
    }
}