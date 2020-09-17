using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x28f1114)]
    public class TLTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x28f1114;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Creator { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Default { get; set; }
        [MTParameter(Order = 3)]
        public long Id { get; set; }
        [MTParameter(Order = 4)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 5)]
        public string Slug { get; set; }
        [MTParameter(Order = 6)]
        public string Title { get; set; }
        [MTParameter(Order = 7, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 8, FromFlag = 3, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLThemeSettings Settings { get; set; }
        [MTParameter(Order = 9)]
        public int InstallsCount { get; set; }


    }
}
