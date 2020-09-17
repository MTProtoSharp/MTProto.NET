using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x5cb367d5)]
    public class TLUpdateTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5cb367d5;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Format { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputTheme Theme { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public string Slug { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsInputDocument Document { get; set; }
        [MTParameter(Order = 6, FromFlag = 3, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLInputThemeSettings Settings { get; set; }


    }
}
