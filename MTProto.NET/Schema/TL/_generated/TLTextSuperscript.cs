using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc7fb5e01)]
    public class TLTextSuperscript : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7fb5e01;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
