using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x70abc3fd)]
    public class TLPageBlockTitle : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x70abc3fd;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Text { get; set; }


    }
}
