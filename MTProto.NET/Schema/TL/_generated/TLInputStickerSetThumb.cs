using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xdbaeae9)]
    public class TLInputStickerSetThumb : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xdbaeae9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet Stickerset { get; set; }
        [MTParameter(Order = 1)]
        public long VolumeId { get; set; }
        [MTParameter(Order = 2)]
        public int LocalId { get; set; }


    }
}
