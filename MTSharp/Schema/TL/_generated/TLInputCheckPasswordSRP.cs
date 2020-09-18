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

namespace MTSharp.Schema.TL
{
    [MTObject(0xd27ff082)]
    public class TLInputCheckPasswordSRP : TLAbsInputCheckPasswordSRP
    {
        public override uint Constructor
        {
            get
            {
                return 0xd27ff082;
            }
        }

		[MTParameter(Order = 0)]
		public long SrpId { get; set; }
		[MTParameter(Order = 1)]
		public byte[] A { get; set; }
		[MTParameter(Order = 2)]
		public byte[] M1 { get; set; }


    }
}
