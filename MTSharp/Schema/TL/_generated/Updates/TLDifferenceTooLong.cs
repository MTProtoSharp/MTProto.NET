using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0x4afe8f6d)]
    public class TLDifferenceTooLong : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x4afe8f6d;
            }
        }

		[MTParameter(Order = 0)]
		public int Pts { get; set; }


    }
}
