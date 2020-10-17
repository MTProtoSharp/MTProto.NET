using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8ffa9a1f)]
    public class TLPageBlockSubtitle : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x8ffa9a1f;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
