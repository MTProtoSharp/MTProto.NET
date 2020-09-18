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
    [MTObject(0xc1b15d65)]
    public class TLInputBotInlineMessageMediaGeo : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xc1b15d65;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 2)]
		public int Period { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
