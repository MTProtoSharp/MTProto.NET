using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x86471d92)]
    public class TLSecurePasswordKdfAlgoSHA512 : TLAbsSecurePasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0x86471d92;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Salt { get; set; }


    }
}
