using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa8718dc5)]
    public class TLPageBlockEmbed : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xa8718dc5;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool FullWidth { get; set; }
        [MTParameter(Order = 2, FromFlag = 3, FlagType = FlagType.True)]
        public bool AllowScrolling { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.Null)]
        public string Html { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.Null)]
        public long? PosterPhotoId { get; set; }
        [MTParameter(Order = 6, FromFlag = 5, FlagType = FlagType.Null)]
        public int? W { get; set; }
        [MTParameter(Order = 7, FromFlag = 5, FlagType = FlagType.Null)]
        public int? H { get; set; }
        [MTParameter(Order = 8)]
        public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
