using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x353a686b)]
    public class TLMessageFwdHeader : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x353a686b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 5, FlagType = FlagType.Null)]
        public string FromName { get; set; }
        [MTParameter(Order = 3)]
        public int Date { get; set; }
        [MTParameter(Order = 4, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? ChannelId { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? ChannelPost { get; set; }
        [MTParameter(Order = 6, FlagBitId = 3, FlagType = FlagType.Null)]
        public string PostAuthor { get; set; }
        [MTParameter(Order = 7, FlagBitId = 4, FlagType = FlagType.Null)]
        public TLAbsPeer SavedFromPeer { get; set; }
        [MTParameter(Order = 8, FlagBitId = 4, FlagType = FlagType.Null)]
        public int? SavedFromMsgId { get; set; }
        [MTParameter(Order = 9, FlagBitId = 6, FlagType = FlagType.Null)]
        public string PsaType { get; set; }


    }
}
