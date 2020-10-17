using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x869d758f)]
    public class TLSecureValueError : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0x869d758f;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Hash { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
