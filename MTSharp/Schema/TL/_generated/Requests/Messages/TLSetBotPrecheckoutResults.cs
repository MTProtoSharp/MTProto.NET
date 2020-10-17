using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x9c2dd95)]
    public class TLSetBotPrecheckoutResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c2dd95;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Success { get; set; }
        [MTParameter(Order = 2)]
        public long QueryId { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Error { get; set; }


    }
}
