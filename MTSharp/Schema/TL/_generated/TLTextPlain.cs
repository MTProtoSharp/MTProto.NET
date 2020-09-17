using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x744694e0)]
    public class TLTextPlain : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x744694e0;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
