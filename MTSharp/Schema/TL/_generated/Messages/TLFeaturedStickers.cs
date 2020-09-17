using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xf89d88e5)]
    public class TLFeaturedStickers : TLAbsFeaturedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xf89d88e5;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<long> Unread { get; set; }


    }
}
