using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xc0e24635)]
    public class TLDhConfigNotModified : TLAbsDhConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0xc0e24635;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Random { get; set; }


    }
}
