using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x4ede3cf)]
    public class TLFeaturedStickersNotModified : TLAbsFeaturedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0x4ede3cf;
            }
        }



    }
}
