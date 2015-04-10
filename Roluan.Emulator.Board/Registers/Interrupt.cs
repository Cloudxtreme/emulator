using Roluan.Common;
using Roluan.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roluan.Board.Base.Registers
{
   public class Interrupt
    {

        public InterruptType InterruptType { get; set; }
        public int Address { get; set; }// ---
        public InterruptPriorityLevel InterruptPriority { get; set; }
        public int RegisterAllocated { get; set; }
    }
}
