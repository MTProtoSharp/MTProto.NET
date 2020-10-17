using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xb574b16b)]
    public class TLSetContentSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb574b16b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool SensitiveEnabled { get; set; }


    }
}
