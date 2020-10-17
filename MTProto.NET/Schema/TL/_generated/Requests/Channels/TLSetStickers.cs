using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xea8ca4f9)]
    public class TLSetStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xea8ca4f9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputStickerSet Stickerset { get; set; }


    }
}
