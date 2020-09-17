using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9a8ae1e1)]
    public class TLPageBlockOrderedList : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a8ae1e1;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPageListOrderedItem> Items { get; set; }


    }
}
