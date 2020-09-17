using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc7f49b7)]
    public class TLPrivacyValueDisallowUsers : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7f49b7;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Users { get; set; }


    }
}
