using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long Id { get; set; }
        [MTParameter(Order = 2)]
        public string Url { get; set; }
        [MTParameter(Order = 3)]
        public string DisplayUrl { get; set; }
        [MTParameter(Order = 4)]
        public int Hash { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Type { get; set; }
        [MTParameter(Order = 6, FlagBitId = 1, FlagType = FlagType.Null)]
        public string SiteName { get; set; }
        [MTParameter(Order = 7, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 8, FlagBitId = 3, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 9, FlagBitId = 4, FlagType = FlagType.Null)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 10, FlagBitId = 5, FlagType = FlagType.Null)]
        public string EmbedUrl { get; set; }
        [MTParameter(Order = 11, FlagBitId = 5, FlagType = FlagType.Null)]
        public string EmbedType { get; set; }
        [MTParameter(Order = 12, FlagBitId = 6, FlagType = FlagType.Null)]
        public int? EmbedWidth { get; set; }
        [MTParameter(Order = 13, FlagBitId = 6, FlagType = FlagType.Null)]
        public int? EmbedHeight { get; set; }
        [MTParameter(Order = 14, FlagBitId = 7, FlagType = FlagType.Null)]
        public int? Duration { get; set; }
        [MTParameter(Order = 15, FlagBitId = 8, FlagType = FlagType.Null)]
        public string Author { get; set; }
        [MTParameter(Order = 16, FlagBitId = 9, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 17, FlagBitId = 10, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLPage CachedPage { get; set; }
        [MTParameter(Order = 18, FlagBitId = 12, FlagType = FlagType.Null)]
        public TLVector<MTProto.NET.Schema.TL.TLWebPageAttributeTheme> Attributes { get; set; }


    }
}
