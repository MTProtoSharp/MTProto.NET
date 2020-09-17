using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6c37c15c)]
    public class TLDocumentAttributeImageSize : TLAbsDocumentAttribute
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c37c15c;
            }
        }

        [MTParameter(Order = 0)]
        public int W { get; set; }
        [MTParameter(Order = 1)]
        public int H { get; set; }


    }
}
