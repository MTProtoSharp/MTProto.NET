using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Currency { get; set; }
        [MTParameter(Order = 2)]
        public long TotalAmount { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Payload { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLPaymentRequestedInfo Info { get; set; }
        [MTParameter(Order = 5, FlagBitId = 1, FlagType = FlagType.Null)]
        public string ShippingOptionId { get; set; }
        [MTParameter(Order = 6)]
        public MTProto.NET.Schema.TL.TLPaymentCharge Charge { get; set; }


    }
}
