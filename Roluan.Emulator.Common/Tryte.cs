using System.Collections.Generic;

namespace Roluan.Emulator.Common
{
    /// <summary>
    /// Class that represents a Tryte
    /// </summary>
    public class Tryte
    {
        #region Properties

        public List<Trit> Trits { get; private set; }

        #endregion

        public Tryte()
        {
            Initialize();
        }

        void Initialize()
        {
            Trits = new List<Trit>();

            for (int i = 0; i < Config.TRYTE_SIZE; i++)
            {
                Trits.Add(new Trit());
            }
        }
    }
}
