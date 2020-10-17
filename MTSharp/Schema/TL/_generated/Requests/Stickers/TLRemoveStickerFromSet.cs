using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Stickers
{
    [MTObject(0xf7760f51)]
    public class TLRemoveStickerFromSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf7760f51;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputDocument Sticker { get; set; }


    }
}
