using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common
{
    /// <summary>
    /// Class that represents a Trit
    /// </summary>
    public class Trit
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Trit"/> class.
        /// The default state of Trit is Zero.
        /// </summary>
        public Trit()
        {
            State = TritState.Zero;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roluan.Emulator.Common.Trit"/> class.
        /// </summary>
        /// <param name="state">The state that the <see cref="Trit"/> will have</param>
        public Trit(TritState state)
        {
            State = state;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Trit"/> state.
        /// </summary>
        /// <value>The state.</value>
        public TritState State { get; set; }

        #endregion
    }
}
