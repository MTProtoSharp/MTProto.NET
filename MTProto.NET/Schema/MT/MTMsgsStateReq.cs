using MTProto.NET.Attributes;
using MTProto.NET.Schema.TL;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0xda69fb52)]
    public class MTMsgsStateReq : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xda69fb52;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> MsgIds { get; set; }


    }
}
