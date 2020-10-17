using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x1d2652ee)]
    public class TLFinishTakeoutSession : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1d2652ee;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Success { get; set; }


    }
}
