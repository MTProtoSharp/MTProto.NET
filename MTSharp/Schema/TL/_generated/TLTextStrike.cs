using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9bf8bb95)]
    public class TLTextStrike : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x9bf8bb95;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
