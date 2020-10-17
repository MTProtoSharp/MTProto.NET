using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x6f747657)]
    public class TLPageCaption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6f747657;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsRichText Credit { get; set; }


    }
}
