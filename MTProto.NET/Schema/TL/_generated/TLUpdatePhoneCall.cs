using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xab0f6b1e)]
    public class TLUpdatePhoneCall : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xab0f6b1e;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPhoneCall PhoneCall { get; set; }


    }
}
