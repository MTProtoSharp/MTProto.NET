using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5367e5be)]
    public class TLInputSecureFile : TLAbsInputSecureFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x5367e5be;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
