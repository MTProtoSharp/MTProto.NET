using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x35553762)]
    public class TLTextAnchor : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x35553762;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public string Name { get; set; }


    }
}
