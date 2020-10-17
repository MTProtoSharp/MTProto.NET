using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbbc7515d)]
    public class TLKeyboardButtonRequestPoll : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xbbc7515d;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public bool? Quiz { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
