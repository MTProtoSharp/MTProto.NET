using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbe3dfa)]
    public class TLSecureValueErrorFrontSide : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0xbe3dfa;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 1)]
        public byte[] FileHash { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
