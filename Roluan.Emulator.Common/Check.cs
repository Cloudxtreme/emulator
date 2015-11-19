using Roluan.Emulator.Common.Exceptions;

namespace Roluan.Emulator.Common
{
    /// <summary>
    /// Class that performs various checks against objects
    /// </summary>
    public static class Check
    {
        /// <summary>
        /// Check if an item is null
        /// </summary>
        /// <param name="item">The item to check</param>
        public static void IsNull(object item)
        {
            if (item == null)
            {
                throw new NullObjectException();
            }
        }
    }
}