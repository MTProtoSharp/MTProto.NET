using MTSharp.Attributes;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.MT
{
    [MTObject(0x05162463)]
    public class MTResPQ : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x05162463;
            }
        }

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Pq { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<long> ServerPublicKeyFingerprints { get; set; }


    }
}
