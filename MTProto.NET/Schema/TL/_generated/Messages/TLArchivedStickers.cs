using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x4fcba9c8)]
    public class TLArchivedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4fcba9c8;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }


    }
}
