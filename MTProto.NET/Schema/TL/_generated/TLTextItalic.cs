using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd912a59c)]
    public class TLTextItalic : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xd912a59c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
