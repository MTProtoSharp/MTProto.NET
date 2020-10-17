using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3f460fed)]
    public class TLChatParticipants : TLAbsChatParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f460fed;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChatParticipant> Participants { get; set; }
        [MTParameter(Order = 2)]
        public int Version { get; set; }


    }
}
