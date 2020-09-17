using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8f31b327)]
    public class TLMessageActionPaymentSentMe : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x8f31b327;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Currency { get; set; }
        [MTParameter(Order = 2)]
        public long TotalAmount { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Payload { get; set; }
        [MTParameter(Order = 4, FromFlag = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPaymentRequestedInfo Info { get; set; }
        [MTParameter(Order = 5, FromFlag = 1, FlagType = FlagType.Null)]
        public string ShippingOptionId { get; set; }
        [MTParameter(Order = 6)]
        public MTSharp.Schema.TL.TLPaymentCharge Charge { get; set; }


    }
}
