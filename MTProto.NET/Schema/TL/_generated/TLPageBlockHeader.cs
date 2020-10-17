using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbfd064ec)]
    public class TLPageBlockHeader : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xbfd064ec;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
