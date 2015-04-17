using Roluan.Emulator.Board.Components.Bus;

namespace Roluan.Emulator.Board
{
    public class MainBoard
    {

        #region Methods

        public void PowerUp()
        {
            new InternalBus();
        }

        #endregion
    }
}