using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x84551347)]
    public class TLMessageMediaInvoice : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x84551347;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool ShippingAddressRequested { get; set; }
        [MTParameter(Order = 2, FlagBitId = 3, FlagType = FlagType.True)]
        public bool Test { get; set; }
        [MTParameter(Order = 3)]
        public string Title { get; set; }
        [MTParameter(Order = 4)]
        public string Description { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsWebDocument Photo { get; set; }
        [MTParameter(Order = 6, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? ReceiptMsgId { get; set; }
        [MTParameter(Order = 7)]
        public string Currency { get; set; }
        [MTParameter(Order = 8)]
        public long TotalAmount { get; set; }
        [MTParameter(Order = 9)]
        public string StartParam { get; set; }


    }
}
