using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x909c3f94)]
    public class TLPaymentRequestedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x909c3f94;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public string Name { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public string Phone { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public string Email { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPostAddress ShippingAddress { get; set; }


    }
}
