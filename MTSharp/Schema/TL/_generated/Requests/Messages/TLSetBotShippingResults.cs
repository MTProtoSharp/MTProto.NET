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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xe5f672fa)]
    public class TLSetBotShippingResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5f672fa;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public long QueryId { get; set; }
		[MTParameter(Order = 2, FlagBitId=0, FlagType= FlagType.Null)]
		public string Error { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public TLVector<MTSharp.Schema.TL.TLShippingOption> ShippingOptions { get; set; }


    }
}
