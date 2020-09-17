using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa437c3ed)]
    public class TLWallPaper : TLAbsWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0xa437c3ed;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Flags { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.True)]
        public bool Creator { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.True)]
        public bool Default { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
        public bool Pattern { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.True)]
        public bool Dark { get; set; }
        [MTParameter(Order = 6)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 7)]
        public string Slug { get; set; }
        [MTParameter(Order = 8)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 9, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
