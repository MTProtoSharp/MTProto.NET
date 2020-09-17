using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x568a748)]
    public class TLKeyboardButtonSwitchInline : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x568a748;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool SamePeer { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }
        [MTParameter(Order = 3)]
        public string Query { get; set; }


    }
}
