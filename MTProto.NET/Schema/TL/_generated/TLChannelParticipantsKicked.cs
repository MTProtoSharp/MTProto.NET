using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa3b54985)]
    public class TLChannelParticipantsKicked : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xa3b54985;
            }
        }

        [MTParameter(Order = 0)]
        public string Q { get; set; }


    }
}
