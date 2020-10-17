using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xedfd405f)]
    public class TLAllStickers : TLAbsAllStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xedfd405f;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTProto.NET.Schema.TL.TLStickerSet> Sets { get; set; }


    }
}
