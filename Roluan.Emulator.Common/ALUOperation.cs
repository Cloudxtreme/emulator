using Roluan.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roluan.Emulator.Common;

namespace Roluan.Processor.Driver
{
    public class ALUOperation
    {
        public String OperationName { get; set; }
        public List<Trit> OperationCode { get; set; }
    }
}
