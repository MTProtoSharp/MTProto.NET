using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
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
        public TLVector<MTSharp.Schema.TL.TLStickerSet> Sets { get; set; }


    }
}
