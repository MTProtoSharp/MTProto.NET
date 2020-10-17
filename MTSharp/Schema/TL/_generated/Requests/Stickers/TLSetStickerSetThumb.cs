using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Stickers
{
    [MTObject(0x9a364e30)]
    public class TLSetStickerSetThumb : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a364e30;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet Stickerset { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputDocument Thumb { get; set; }


    }
}
