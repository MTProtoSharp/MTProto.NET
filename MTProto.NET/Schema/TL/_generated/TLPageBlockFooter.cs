using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x48870999)]
    public class TLPageBlockFooter : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x48870999;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
