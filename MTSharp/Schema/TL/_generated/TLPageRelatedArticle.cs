using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb390dc08)]
    public class TLPageRelatedArticle : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb390dc08;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }
        [MTParameter(Order = 2)]
        public long WebpageId { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public long? PhotoId { get; set; }
        [MTParameter(Order = 6, FromFlag = 3, FlagType = FlagType.Null)]
        public string Author { get; set; }
        [MTParameter(Order = 7, FromFlag = 4, FlagType = FlagType.Null)]
        public int? PublishedDate { get; set; }


    }
}
