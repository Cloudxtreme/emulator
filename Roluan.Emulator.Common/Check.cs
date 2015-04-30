using Roluan.Emulator.Common.Exceptions;

namespace Roluan.Emulator.Common
{
    public static class Check
    {
        public static void IsNull(object item)
        {
            if(item == null)
            {
                throw new NullTernaryObjectException();
            }
        }
    }
}