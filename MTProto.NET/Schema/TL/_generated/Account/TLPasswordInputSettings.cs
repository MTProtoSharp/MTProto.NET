using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Account
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsPasswordKdfAlgo NewAlgo { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public byte[] NewPasswordHash { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Hint { get; set; }
        [MTParameter(Order = 4, FlagBitId = 1, FlagType = FlagType.Null)]
        public string Email { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLSecureSecretSettings NewSecureSettings { get; set; }


    }
}
