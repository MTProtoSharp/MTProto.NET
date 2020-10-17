using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfc900c2b)]
    public class TLChatParticipantsForbidden : TLAbsChatParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc900c2b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int ChatId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsChatParticipant SelfParticipant { get; set; }


    }
}
