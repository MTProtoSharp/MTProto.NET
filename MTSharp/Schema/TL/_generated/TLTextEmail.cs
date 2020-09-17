using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xde5a0dd6)]
    public class TLTextEmail : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xde5a0dd6;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public string Email { get; set; }


    }
}
