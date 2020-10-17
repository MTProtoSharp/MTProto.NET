using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x34b8621)]
    public class TLTextMarked : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x34b8621;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
