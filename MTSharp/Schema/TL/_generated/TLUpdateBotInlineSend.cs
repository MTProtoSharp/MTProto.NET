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
    [MTObject(0xe48f964)]
    public class TLUpdateBotInlineSend : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe48f964;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public int UserId { get; set; }
		[MTParameter(Order = 2)]
		public string Query { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsGeoPoint Geo { get; set; }
		[MTParameter(Order = 4)]
		public string Id { get; set; }
		[MTParameter(Order = 5, FlagBitId=1, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLInputBotInlineMessageID MsgId { get; set; }


    }
}
