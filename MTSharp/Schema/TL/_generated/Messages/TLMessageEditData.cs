using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x26b5dde6)]
    public class TLMessageEditData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x26b5dde6;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Caption { get; set; }


    }
}
