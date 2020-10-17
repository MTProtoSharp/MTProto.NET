using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
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
        public TLVector<MTProto.NET.Schema.TL.TLAuthorization> Authorizations { get; set; }


    }
}
