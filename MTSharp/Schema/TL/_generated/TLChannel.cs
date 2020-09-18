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
    [MTObject(0xd31a961e)]
    public class TLChannel : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xd31a961e;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Creator { get; set; }
		[MTParameter(Order = 2, FlagBitId=2, FlagType= FlagType.True)]
		public bool Left { get; set; }
		[MTParameter(Order = 3, FlagBitId=5, FlagType= FlagType.True)]
		public bool Broadcast { get; set; }
		[MTParameter(Order = 4, FlagBitId=7, FlagType= FlagType.True)]
		public bool Verified { get; set; }
		[MTParameter(Order = 5, FlagBitId=8, FlagType= FlagType.True)]
		public bool Megagroup { get; set; }
		[MTParameter(Order = 6, FlagBitId=9, FlagType= FlagType.True)]
		public bool Restricted { get; set; }
		[MTParameter(Order = 7, FlagBitId=11, FlagType= FlagType.True)]
		public bool Signatures { get; set; }
		[MTParameter(Order = 8, FlagBitId=12, FlagType= FlagType.True)]
		public bool Min { get; set; }
		[MTParameter(Order = 9, FlagBitId=19, FlagType= FlagType.True)]
		public bool Scam { get; set; }
		[MTParameter(Order = 10, FlagBitId=20, FlagType= FlagType.True)]
		public bool HasLink { get; set; }
		[MTParameter(Order = 11, FlagBitId=21, FlagType= FlagType.True)]
		public bool HasGeo { get; set; }
		[MTParameter(Order = 12, FlagBitId=22, FlagType= FlagType.True)]
		public bool SlowmodeEnabled { get; set; }
		[MTParameter(Order = 13)]
		public int Id { get; set; }
		[MTParameter(Order = 14, FlagBitId=13, FlagType= FlagType.Null)]
		public long? AccessHash { get; set; }
		[MTParameter(Order = 15)]
		public string Title { get; set; }
		[MTParameter(Order = 16, FlagBitId=6, FlagType= FlagType.Null)]
		public string Username { get; set; }
		[MTParameter(Order = 17)]
		public TLAbsChatPhoto Photo { get; set; }
		[MTParameter(Order = 18)]
		public int Date { get; set; }
		[MTParameter(Order = 19)]
		public int Version { get; set; }
		[MTParameter(Order = 20, FlagBitId=9, FlagType= FlagType.Null)]
		public TLVector<MTSharp.Schema.TL.TLRestrictionReason> RestrictionReason { get; set; }
		[MTParameter(Order = 21, FlagBitId=14, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLChatAdminRights AdminRights { get; set; }
		[MTParameter(Order = 22, FlagBitId=15, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLChatBannedRights BannedRights { get; set; }
		[MTParameter(Order = 23, FlagBitId=18, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLChatBannedRights DefaultBannedRights { get; set; }
		[MTParameter(Order = 24, FlagBitId=17, FlagType= FlagType.Null)]
		public int? ParticipantsCount { get; set; }


    }
}
