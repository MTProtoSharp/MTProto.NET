using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x39f23300)]
    public class TLPageBlockCover : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x39f23300;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPageBlock Cover { get; set; }


    }
}
