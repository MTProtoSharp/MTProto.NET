using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x54b56617)]
    public class TLWebPageAttributeTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x54b56617;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsDocument> Documents { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLThemeSettings Settings { get; set; }


    }
}
