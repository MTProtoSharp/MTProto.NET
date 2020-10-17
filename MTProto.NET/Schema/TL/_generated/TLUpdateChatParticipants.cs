using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7761198)]
    public class TLUpdateChatParticipants : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x7761198;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChatParticipants Participants { get; set; }


    }
}
