using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xce0d37b0)]
    public class TLPageBlockAnchor : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xce0d37b0;
            }
        }

        [MTParameter(Order = 0)]
        public string Name { get; set; }


    }
}
