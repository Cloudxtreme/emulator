namespace Roluan.Emulator.Common.Gates
{
    public static class TXOR
    {
        public static Trit Output(Trit inputA, Trit inputB)
        { 
            return TAND.Output(TNAND.Output(inputA, inputB), TOR.Output(inputA, inputB));
        }
    }
}