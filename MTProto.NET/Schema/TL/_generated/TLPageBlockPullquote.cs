using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4f4456d3)]
    public class TLPageBlockPullquote : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x4f4456d3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsRichText Caption { get; set; }


    }
}
