using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc070d93e)]
    public class TLPageBlockPreformatted : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xc070d93e;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public string Language { get; set; }


    }
}
