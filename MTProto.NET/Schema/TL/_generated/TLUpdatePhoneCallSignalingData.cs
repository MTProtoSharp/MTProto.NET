using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x2661bf09)]
    public class TLUpdatePhoneCallSignalingData : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x2661bf09;
            }
        }

        [MTParameter(Order = 0)]
        public long PhoneCallId { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Data { get; set; }


    }
}
