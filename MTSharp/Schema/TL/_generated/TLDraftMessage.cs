using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xfd8e711f)]
    public class TLDraftMessage : TLAbsDraftMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xfd8e711f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool NoWebpage { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 3)]
        public string Message { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 5)]
        public int Date { get; set; }


    }
}
