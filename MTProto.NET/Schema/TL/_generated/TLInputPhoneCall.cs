using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1e36fded)]
    public class TLInputPhoneCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e36fded;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
