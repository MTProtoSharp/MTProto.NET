using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3c2884c1)]
    public class TLTextUrl : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x3c2884c1;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }
        [MTParameter(Order = 2)]
        public long WebpageId { get; set; }


    }
}
