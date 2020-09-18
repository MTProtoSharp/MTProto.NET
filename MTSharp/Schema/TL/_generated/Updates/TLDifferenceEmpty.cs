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
    [MTObject(0x5d75a138)]
    public class TLDifferenceEmpty : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x5d75a138;
            }
        }

		[MTParameter(Order = 0)]
		public int Date { get; set; }
		[MTParameter(Order = 1)]
		public int Seq { get; set; }


    }
}
