using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x467a0766)]
    public class TLPageBlockParagraph : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x467a0766;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
