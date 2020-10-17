using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0xad2e1cd8)]
    public class TLAuthorizationForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad2e1cd8;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsSecureRequiredType> RequiredTypes { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTProto.NET.Schema.TL.TLSecureValue> Values { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsSecureValueError> Errors { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsUser> Users { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public string PrivacyPolicyUrl { get; set; }


    }
}
