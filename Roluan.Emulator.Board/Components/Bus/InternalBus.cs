namespace Roluan.Emulator.Board.Components.Bus
{
    public class InternalBus
    {
        #region Constructors

        public InternalBus()
        {
            SouthBridge = new SouthBridge();
            NorthBridge = new NorthBridge();
        }

        #endregion

        #region Properties

        public NorthBridge NorthBridge { get; private set; }

        public SouthBridge SouthBridge { get; private set; }

        #endregion
    }
}