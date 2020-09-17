using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe89c45b2)]
    public class TLWebPage : TLAbsWebPage
    {
        public override uint Constructor
        {
            get
            {
                return 0xe89c45b2;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long Id { get; set; }
        [MTParameter(Order = 2)]
        public string Url { get; set; }
        [MTParameter(Order = 3)]
        public string DisplayUrl { get; set; }
        [MTParameter(Order = 4)]
        public int Hash { get; set; }
        [MTParameter(Order = 5, FromFlag = 0, FlagType = FlagType.Null)]
        public string Type { get; set; }
        [MTParameter(Order = 6, FromFlag = 1, FlagType = FlagType.Null)]
        public string SiteName { get; set; }
        [MTParameter(Order = 7, FromFlag = 2, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 8, FromFlag = 3, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 9, FromFlag = 4, FlagType = FlagType.Null)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 10, FromFlag = 5, FlagType = FlagType.Null)]
        public string EmbedUrl { get; set; }
        [MTParameter(Order = 11, FromFlag = 5, FlagType = FlagType.Null)]
        public string EmbedType { get; set; }
        [MTParameter(Order = 12, FromFlag = 6, FlagType = FlagType.Null)]
        public int? EmbedWidth { get; set; }
        [MTParameter(Order = 13, FromFlag = 6, FlagType = FlagType.Null)]
        public int? EmbedHeight { get; set; }
        [MTParameter(Order = 14, FromFlag = 7, FlagType = FlagType.Null)]
        public int? Duration { get; set; }
        [MTParameter(Order = 15, FromFlag = 8, FlagType = FlagType.Null)]
        public string Author { get; set; }
        [MTParameter(Order = 16, FromFlag = 9, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 17, FromFlag = 10, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPage CachedPage { get; set; }
        [MTParameter(Order = 18, FromFlag = 12, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLWebPageAttributeTheme> Attributes { get; set; }


    }
}
