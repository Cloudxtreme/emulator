using Roluan.Emulator.Board.Components;

namespace Roluan.Emulator.Board
{
    public class Mainboard
    {
        #region Constructors

        public Mainboard()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public Bios Bios { get; private set; }

        #endregion

        #region Methods

        void Initialize()
        {
            Bios = new Bios();
        }

        #endregion
    }
}