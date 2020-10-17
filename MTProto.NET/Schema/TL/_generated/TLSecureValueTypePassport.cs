using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3dac6a00)]
    public class TLSecureValueTypePassport : TLAbsSecureValueType
    {
        public override uint Constructor
        {
            get
            {
                return 0x3dac6a00;
            }
        }



    }
}
