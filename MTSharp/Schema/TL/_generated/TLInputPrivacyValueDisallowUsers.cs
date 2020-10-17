using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x90110467)]
    public class TLInputPrivacyValueDisallowUsers : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x90110467;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputUser> Users { get; set; }


    }
}
