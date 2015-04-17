using System.Collections.Generic;
using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Base
{
    public class InfoRegister: RegisterBase
    {
        public InfoRegister()
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