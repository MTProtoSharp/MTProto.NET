using MTProto.NET.Attributes;
using MTProto.NET.Schema.TL;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x62d6b459)]
    public class MTMsgsAck : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x62d6b459;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> MsgIds { get; set; }


    }
}
