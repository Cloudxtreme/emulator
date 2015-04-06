﻿using Roluan.Board.Registers;

namespace Roluan.Board
{
    public class ROM
    {
        public SymbolsRegister SymbolsRegister { get; private set; }

        public InterruptsRegister InterruptsRegister { get; private set; }

        public ROM()
        {

            SymbolsRegister = new SymbolsRegister();
            InterruptsRegister = new InterruptsRegister();
        }
    }
}
