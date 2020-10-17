using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1ccb966a)]
    public class TLTextPhone : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x1ccb966a;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 1)]
        public string Phone { get; set; }


    }
}
