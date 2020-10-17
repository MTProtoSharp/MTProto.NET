using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Auth
{
    [MTObject(0x390d5c5e)]
    public class TLLoginTokenSuccess : TLAbsLoginToken
    {
        public override uint Constructor
        {
            get
            {
                return 0x390d5c5e;
            }
        }

        [MTParameter(Order = 0)]
        public Auth.TLAbsAuthorization Authorization { get; set; }


    }
}
