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
    [MTObject(0x9b9240a6)]
    public class TLUpdateBotWebhookJSONQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x9b9240a6;
            }
        }

		[MTParameter(Order = 0)]
		public long QueryId { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLDataJSON Data { get; set; }
		[MTParameter(Order = 2)]
		public int Timeout { get; set; }


    }
}
