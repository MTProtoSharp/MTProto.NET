using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x8999602d)]
    public class TLClearRecentStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8999602d;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Attached { get; set; }


    }
}
