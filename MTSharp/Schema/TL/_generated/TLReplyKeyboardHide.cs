using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa03e5b85)]
    public class TLReplyKeyboardHide : TLAbsReplyMarkup
    {
        public override uint Constructor
        {
            get
            {
                return 0xa03e5b85;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 2, FlagType = FlagType.True)]
        public bool Selective { get; set; }


    }
}
