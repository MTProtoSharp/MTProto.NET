using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd02e7fd4)]
    public class TLInputKeyboardButtonUrlAuth : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xd02e7fd4;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool RequestWriteAccess { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public string FwdText { get; set; }
        [MTParameter(Order = 4)]
        public string Url { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsInputUser Bot { get; set; }


    }
}
