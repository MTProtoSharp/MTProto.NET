using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4d5bbe0c)]
    public class TLPrivacyValueAllowUsers : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x4d5bbe0c;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Users { get; set; }


    }
}
