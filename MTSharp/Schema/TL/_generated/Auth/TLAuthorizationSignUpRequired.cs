using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x44747e9a)]
    public class TLAuthorizationSignUpRequired : TLAbsAuthorization
    {
        public override uint Constructor
        {
            get
            {
                return 0x44747e9a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.Help.TLTermsOfService TermsOfService { get; set; }


    }
}
