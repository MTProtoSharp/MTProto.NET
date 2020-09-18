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
    [MTObject(0x1b7c9db3)]
    public class TLChatFull : TLAbsChatFull
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b7c9db3;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=7, FlagType= FlagType.True)]
		public bool CanSetUsername { get; set; }
		[MTParameter(Order = 2, FlagBitId=8, FlagType= FlagType.True)]
		public bool HasScheduled { get; set; }
		[MTParameter(Order = 3)]
		public int Id { get; set; }
		[MTParameter(Order = 4)]
		public string About { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsChatParticipants Participants { get; set; }
		[MTParameter(Order = 6, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsPhoto ChatPhoto { get; set; }
		[MTParameter(Order = 7)]
		public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsExportedChatInvite ExportedInvite { get; set; }
		[MTParameter(Order = 9, FlagBitId=3, FlagType= FlagType.Null)]
		public TLVector<MTSharp.Schema.TL.TLBotInfo> BotInfo { get; set; }
		[MTParameter(Order = 10, FlagBitId=6, FlagType= FlagType.Null)]
		public int? PinnedMsgId { get; set; }
		[MTParameter(Order = 11, FlagBitId=11, FlagType= FlagType.Null)]
		public int? FolderId { get; set; }


    }
}
