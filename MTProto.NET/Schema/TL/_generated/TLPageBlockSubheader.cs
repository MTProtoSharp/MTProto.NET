using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf12bb6e1)]
    public class TLPageBlockSubheader : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xf12bb6e1;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
