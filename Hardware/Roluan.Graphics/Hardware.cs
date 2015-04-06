using Roluan.Common;
using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
using System.Collections.Generic;

namespace Roluan
{
    public class Hardware : IGraphicHardware
    {
        public PriorityType PriorityType
        {
            get { return PriorityType.High; }
        }

        public long Size
        {
            get { return 19683; }
        }

    }
}
