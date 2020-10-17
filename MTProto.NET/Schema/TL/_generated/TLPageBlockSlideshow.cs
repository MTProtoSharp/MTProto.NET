using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x31f9590)]
    public class TLPageBlockSlideshow : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x31f9590;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPageBlock> Items { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
