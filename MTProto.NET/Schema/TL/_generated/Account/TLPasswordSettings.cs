using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Account
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Email { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLSecureSecretSettings SecureSettings { get; set; }


    }
}
