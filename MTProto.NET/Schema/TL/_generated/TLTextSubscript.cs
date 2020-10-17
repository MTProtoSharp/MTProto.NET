using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xed6a8504)]
    public class TLTextSubscript : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xed6a8504;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
