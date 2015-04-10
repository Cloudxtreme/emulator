using System.Collections.Generic;
using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common
{
    public class Tryte
    {
        public List<Trit> Trits { get; set; }

        public Tryte()
        {
            Initialize();
        }

        private void Initialize()
        {
            Trits = new List<Trit>();

            for (int i = 0; i < Config.TRYTE_SIZE; i++)
            {
                Trits.Add(new Trit { State = TritState.Zero });
            }
        }
    }
}