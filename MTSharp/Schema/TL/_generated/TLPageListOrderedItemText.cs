using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5e068047)]
    public class TLPageListOrderedItemText : TLAbsPageListOrderedItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x5e068047;
            }
        }

        [MTParameter(Order = 0)]
        public string Num { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsRichText Text { get; set; }


    }
}
