using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0xc23727c9)]
    public class TLPasswordInputSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc23727c9;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsPasswordKdfAlgo NewAlgo { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public byte[] NewPasswordHash { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public string Hint { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public string Email { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLSecureSecretSettings NewSecureSettings { get; set; }


    }
}
