using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbbf2dda0)]
    public class TLSecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 : TLAbsSecurePasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0xbbf2dda0;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Salt { get; set; }


    }
}
