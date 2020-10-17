using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xc6dc0c66)]
    public class TLFeaturedStickersNotModified : TLAbsFeaturedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xc6dc0c66;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }


    }
}
