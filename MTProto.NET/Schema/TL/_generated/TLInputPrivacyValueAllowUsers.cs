using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x131cc67f)]
    public class TLInputPrivacyValueAllowUsers : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x131cc67f;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputUser> Users { get; set; }


    }
}
