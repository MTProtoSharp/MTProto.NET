using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6724abc4)]
    public class TLTextBold : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x6724abc4;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
