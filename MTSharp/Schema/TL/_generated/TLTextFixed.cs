using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6c3f19b9)]
    public class TLTextFixed : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c3f19b9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
