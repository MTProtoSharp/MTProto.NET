using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x8432c21f)]
    public class TLCreateTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8432c21f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Slug { get; set; }
        [MTParameter(Order = 2)]
        public string Title { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsInputDocument Document { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLInputThemeSettings Settings { get; set; }


    }
}
