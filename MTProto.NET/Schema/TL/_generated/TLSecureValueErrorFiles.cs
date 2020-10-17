using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x666220e9)]
    public class TLSecureValueErrorFiles : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0x666220e9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<byte[]> FileHash { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
