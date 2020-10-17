using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb92fb6cd)]
    public class TLPageListItemText : TLAbsPageListItem
    {
        public override uint Constructor
        {
            get
            {
                return 0xb92fb6cd;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
