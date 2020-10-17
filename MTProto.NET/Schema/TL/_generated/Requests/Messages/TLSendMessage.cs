using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x520c3870)]
    public class TLSendMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x520c3870;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool NoWebpage { get; set; }
        [MTParameter(Order = 2, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Silent { get; set; }
        [MTParameter(Order = 3, FlagBitId = 6, FlagType = FlagType.True)]
        public bool Background { get; set; }
        [MTParameter(Order = 4, FlagBitId = 7, FlagType = FlagType.True)]
        public bool ClearDraft { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 6, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 7)]
        public string Message { get; set; }
        [MTParameter(Order = 8)]
        public long RandomId { get; set; }
        [MTParameter(Order = 9, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }
        [MTParameter(Order = 10, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 11, FlagBitId = 10, FlagType = FlagType.Null)]
        public int? ScheduleDate { get; set; }


    }
}
