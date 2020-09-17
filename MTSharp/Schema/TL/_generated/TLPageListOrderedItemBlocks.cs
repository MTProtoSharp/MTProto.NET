using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x98dd8936)]
    public class TLPageListOrderedItemBlocks : TLAbsPageListOrderedItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x98dd8936;
            }
        }

        [MTParameter(Order = 0)]
        public string Num { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsPageBlock> Blocks { get; set; }


    }
}
