using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1527bcac)]
    public class TLSecureSecretSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1527bcac;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecurePasswordKdfAlgo SecureAlgo { get; set; }
        [MTParameter(Order = 1)]
        public byte[] SecureSecret { get; set; }
        [MTParameter(Order = 2)]
        public long SecureSecretId { get; set; }


    }
}
