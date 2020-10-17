using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x81ccf4f)]
    public class TLTextImage : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x81ccf4f;
            }
        }

        [MTParameter(Order = 0)]
        public long DocumentId { get; set; }
        [MTParameter(Order = 1)]
        public int W { get; set; }
        [MTParameter(Order = 2)]
        public int H { get; set; }


    }
}
