using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xef1751b5)]
    public class TLPageBlockChannel : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xef1751b5;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChat Channel { get; set; }


    }
}
