using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xf37f2f16)]
    public class TLFavedStickers : TLAbsFavedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xf37f2f16;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTSharp.Schema.TL.TLStickerPack> Packs { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsDocument> Stickers { get; set; }


    }
}
