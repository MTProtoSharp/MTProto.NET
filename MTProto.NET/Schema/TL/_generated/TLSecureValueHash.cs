using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xed1ecdb0)]
    public class TLSecureValueHash : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xed1ecdb0;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Hash { get; set; }


    }
}
