using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf4108aa0)]
    public class TLReplyKeyboardForceReply : TLAbsReplyMarkup
    {
        public override uint Constructor
        {
            get
            {
                return 0xf4108aa0;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool SingleUse { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.True)]
        public bool Selective { get; set; }


    }
}
