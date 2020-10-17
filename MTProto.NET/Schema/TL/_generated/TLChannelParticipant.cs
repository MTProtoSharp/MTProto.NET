using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x15ebac1d)]
    public class TLChannelParticipant : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0x15ebac1d;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
