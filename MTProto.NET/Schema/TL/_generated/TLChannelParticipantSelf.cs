using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa3289a6d)]
    public class TLChannelParticipantSelf : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xa3289a6d;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int InviterId { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }


    }
}
