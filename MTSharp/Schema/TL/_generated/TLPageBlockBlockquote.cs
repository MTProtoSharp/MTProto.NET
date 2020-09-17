using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x263d7c26)]
    public class TLPageBlockBlockquote : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x263d7c26;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsRichText Caption { get; set; }


    }
}
