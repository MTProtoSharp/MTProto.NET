using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Stickers
{
    [MTObject(0x8653febe)]
    public class TLAddStickerToSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8653febe;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet Stickerset { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLInputStickerSetItem Sticker { get; set; }


    }
}
