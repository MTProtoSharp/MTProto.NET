using MTSharp.Attributes;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.MT
{
    [MTObject(0x8cc0d131)]
    public class MTMsgsAllInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8cc0d131;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> MsgIds { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Info { get; set; }


    }
}
