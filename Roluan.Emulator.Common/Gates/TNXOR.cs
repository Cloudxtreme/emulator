using System;

namespace Roluan.Emulator.Common.Gates
{
    public static class TNXOR
    {
        public static Trit Output(Trit inputA, Trit inputB)
        { 
            return TNOT.Output(TXOR.Output(inputA, inputB));
        }
    }
}