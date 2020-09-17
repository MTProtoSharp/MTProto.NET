using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x9a5c33e5)]
    public class TLPasswordSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a5c33e5;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public string Email { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLSecureSecretSettings SecureSettings { get; set; }


    }
}
