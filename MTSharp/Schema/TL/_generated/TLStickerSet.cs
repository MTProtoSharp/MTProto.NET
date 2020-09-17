using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xeeb46f27)]
    public class TLStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeeb46f27;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Archived { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.True)]
        public bool Official { get; set; }
        [MTParameter(Order = 3, FromFlag = 3, FlagType = FlagType.True)]
        public bool Masks { get; set; }
        [MTParameter(Order = 4, FromFlag = 5, FlagType = FlagType.True)]
        public bool Animated { get; set; }
        [MTParameter(Order = 5, FromFlag = 0, FlagType = FlagType.Null)]
        public int? InstalledDate { get; set; }
        [MTParameter(Order = 6)]
        public long Id { get; set; }
        [MTParameter(Order = 7)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 8)]
        public string Title { get; set; }
        [MTParameter(Order = 9)]
        public string ShortName { get; set; }
        [MTParameter(Order = 10, FromFlag = 4, FlagType = FlagType.Null)]
        public TLAbsPhotoSize Thumb { get; set; }
        [MTParameter(Order = 11, FromFlag = 4, FlagType = FlagType.Null)]
        public int? ThumbDcId { get; set; }
        [MTParameter(Order = 12)]
        public int Count { get; set; }
        [MTParameter(Order = 13)]
        public int Hash { get; set; }


    }
}
