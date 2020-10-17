using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x10b78d29)]
    public class TLKeyboardButtonUrlAuth : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x10b78d29;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Text { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public string FwdText { get; set; }
        [MTParameter(Order = 3)]
        public string Url { get; set; }
        [MTParameter(Order = 4)]
        public int ButtonId { get; set; }


    }
}
