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
    [MTObject(0xe0cdc940)]
    public class TLUpdateBotShippingQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0cdc940;
            }
        }

		[MTParameter(Order = 0)]
		public long QueryId { get; set; }
		[MTParameter(Order = 1)]
		public int UserId { get; set; }
		[MTParameter(Order = 2)]
		public byte[] Payload { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLPostAddress ShippingAddress { get; set; }


    }
}
