using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x33f0ea47)]
    public class TLSecureCredentialsEncrypted : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x33f0ea47;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Data { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Hash { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Secret { get; set; }


    }
}
