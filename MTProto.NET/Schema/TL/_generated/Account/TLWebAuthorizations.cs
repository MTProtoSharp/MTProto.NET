using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0xed56c9fc)]
    public class TLWebAuthorizations : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xed56c9fc;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLWebAuthorization> Authorizations { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
