using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe4e88011)]
    public class TLPageBlockList : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xe4e88011;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPageListItem> Items { get; set; }


    }
}
