using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc12622c4)]
    public class TLTextUnderline : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xc12622c4;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
