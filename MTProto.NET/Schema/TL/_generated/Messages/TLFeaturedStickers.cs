using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xb6abc341)]
    public class TLFeaturedStickers : TLAbsFeaturedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xb6abc341;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public int Count { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<long> Unread { get; set; }


    }
}
