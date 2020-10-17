using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x13567e8a)]
    public class TLPageBlockUnsupported : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x13567e8a;
            }
        }



    }
}
