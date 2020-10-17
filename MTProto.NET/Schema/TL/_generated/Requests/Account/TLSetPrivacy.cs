using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xc9f81ce8)]
    public class TLSetPrivacy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc9f81ce8;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPrivacyKey Key { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsInputPrivacyRule> Rules { get; set; }


    }
}
