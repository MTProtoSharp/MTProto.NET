using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x22f3afb3)]
    public class TLRecentStickers : TLAbsRecentStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0x22f3afb3;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTSharp.Schema.TL.TLStickerPack> Packs { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsDocument> Stickers { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<int> Dates { get; set; }


    }
}
