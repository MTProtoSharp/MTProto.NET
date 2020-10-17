using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xcc0110cb)]
    public class TLSendMultiMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcc0110cb;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Silent { get; set; }
        [MTParameter(Order = 2, FlagBitId = 6, FlagType = FlagType.True)]
        public bool Background { get; set; }
        [MTParameter(Order = 3, FlagBitId = 7, FlagType = FlagType.True)]
        public bool ClearDraft { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<MTSharp.Schema.TL.TLInputSingleMedia> MultiMedia { get; set; }
        [MTParameter(Order = 7, FlagBitId = 10, FlagType = FlagType.Null)]
        public int? ScheduleDate { get; set; }


    }
}
