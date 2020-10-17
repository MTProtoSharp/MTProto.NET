using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1e148390)]
    public class TLPageBlockKicker : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e148390;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
