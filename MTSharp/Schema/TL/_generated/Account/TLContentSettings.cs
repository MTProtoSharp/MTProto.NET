using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x57e28221)]
    public class TLContentSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x57e28221;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool SensitiveEnabled { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool SensitiveCanChange { get; set; }


    }
}
