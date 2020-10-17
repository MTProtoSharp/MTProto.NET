using MTProto.NET.Attributes;
using MTProto.NET.Schema.TL;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x7d861a08)]
    public class MTMsgResendReq : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7d861a08;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> MsgIds { get; set; }


    }
}
