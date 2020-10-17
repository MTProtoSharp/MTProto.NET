using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x25e073fc)]
    public class TLPageListItemBlocks : TLAbsPageListItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x25e073fc;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPageBlock> Blocks { get; set; }


    }
}
