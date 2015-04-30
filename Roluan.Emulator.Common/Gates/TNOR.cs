using System;

namespace Roluan.Emulator.Common.Gates
{
    public static class TNOR
    {
        public static Trit Output(Trit inputA, Trit inputB)
        { 
            return TNOT.Output(TOR.Output(inputA, inputB));
        }
    }
}