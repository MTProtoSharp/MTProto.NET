using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Stickers
{
    [MTObject(0xf1036780)]
    public class TLCreateStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf1036780;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Masks { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Animated { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 4)]
        public string Title { get; set; }
        [MTParameter(Order = 5)]
        public string ShortName { get; set; }
        [MTParameter(Order = 6, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsInputDocument Thumb { get; set; }
        [MTParameter(Order = 7)]
        public TLVector<MTProto.NET.Schema.TL.TLInputStickerSetItem> Stickers { get; set; }


    }
}
