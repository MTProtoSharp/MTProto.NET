using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfb197a65)]
    public class TLPhoto : TLAbsPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0xfb197a65;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool HasStickers { get; set; }
        [MTParameter(Order = 2)]
        public long Id { get; set; }
        [MTParameter(Order = 3)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 4)]
        public byte[] FileReference { get; set; }
        [MTParameter(Order = 5)]
        public int Date { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsPhotoSize> Sizes { get; set; }
        [MTParameter(Order = 7, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<MTProto.NET.Schema.TL.TLVideoSize> VideoSizes { get; set; }
        [MTParameter(Order = 8)]
        public int DcId { get; set; }


    }
}
