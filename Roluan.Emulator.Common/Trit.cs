using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common
{
	public class Trit
	{

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Roluan.Emulator.Common.Trit"/> class.
        /// The default state of Trit is Zero.
        /// </summary>
        public Trit()
        {
            State = TritState.Zero;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roluan.Emulator.Common.Trit"/> class.
        /// </summary>
        /// <param name="state">The state that the Trit will have</param>
        public Trit(TritState state)
        {
            State = state;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public TritState State { get; set; }

        #endregion
	}
}