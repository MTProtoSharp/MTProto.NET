using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xec338270)]
    public class TLMessageFwdHeader : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xec338270;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 2, FromFlag = 5, FlagType = FlagType.Null)]
        public string FromName { get; set; }
        [MTParameter(Order = 3)]
        public int Date { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public int? ChannelId { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public int? ChannelPost { get; set; }
        [MTParameter(Order = 6, FromFlag = 3, FlagType = FlagType.Null)]
        public string PostAuthor { get; set; }
        [MTParameter(Order = 7, FromFlag = 4, FlagType = FlagType.Null)]
        public TLAbsPeer SavedFromPeer { get; set; }
        [MTParameter(Order = 8, FromFlag = 4, FlagType = FlagType.Null)]
        public int? SavedFromMsgId { get; set; }


    }
}
