using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0x60469778)]
    public class MTReqPq : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x60469778;
            }
        }

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }


    }
}
