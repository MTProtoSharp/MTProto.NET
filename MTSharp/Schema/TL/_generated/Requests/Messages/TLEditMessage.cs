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
    [MTObject(0x48f71778)]
    public class TLEditMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x48f71778;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=1, FlagType= FlagType.True)]
		public bool NoWebpage { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 3)]
		public int Id { get; set; }
		[MTParameter(Order = 4, FromFlag=11, FlagType= FlagType.Null)]
		public string Message { get; set; }
		[MTParameter(Order = 5, FromFlag=14, FlagType= FlagType.Null)]
		public TLAbsInputMedia Media { get; set; }
		[MTParameter(Order = 6, FromFlag=2, FlagType= FlagType.Null)]
		public TLAbsReplyMarkup ReplyMarkup { get; set; }
		[MTParameter(Order = 7, FromFlag=3, FlagType= FlagType.Null)]
		public TLVector<TLAbsMessageEntity> Entities { get; set; }
		[MTParameter(Order = 8, FromFlag=15, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}
