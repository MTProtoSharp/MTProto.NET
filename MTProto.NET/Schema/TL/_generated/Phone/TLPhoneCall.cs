using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Phone
{
    [MTObject(0xec82e140)]
    public class TLPhoneCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xec82e140;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPhoneCall PhoneCall { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
