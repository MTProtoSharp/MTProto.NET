using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5d2f3aa9)]
    public class TLUpdateBotPrecheckoutQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x5d2f3aa9;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long QueryId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Payload { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPaymentRequestedInfo Info { get; set; }
        [MTParameter(Order = 5, FlagBitId = 1, FlagType = FlagType.Null)]
        public string ShippingOptionId { get; set; }
        [MTParameter(Order = 6)]
        public string Currency { get; set; }
        [MTParameter(Order = 7)]
        public long TotalAmount { get; set; }


    }
}
