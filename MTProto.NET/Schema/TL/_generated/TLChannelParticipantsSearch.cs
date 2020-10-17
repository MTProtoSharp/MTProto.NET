using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x656ac4b)]
    public class TLChannelParticipantsSearch : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0x656ac4b;
            }
        }

        [MTParameter(Order = 0)]
        public string Q { get; set; }


    }
}
