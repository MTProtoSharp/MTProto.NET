using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x1250abde)]
    public class TLAuthorizations : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1250abde;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLAuthorization> Authorizations { get; set; }


    }
}
