using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0x500911e1)]
    public class TLPaymentReceipt : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x500911e1;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }
        [MTParameter(Order = 2)]
        public int BotId { get; set; }
        [MTParameter(Order = 3)]
        public MTSharp.Schema.TL.TLInvoice Invoice { get; set; }
        [MTParameter(Order = 4)]
        public int ProviderId { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPaymentRequestedInfo Info { get; set; }
        [MTParameter(Order = 6, FlagBitId = 1, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLShippingOption Shipping { get; set; }
        [MTParameter(Order = 7)]
        public string Currency { get; set; }
        [MTParameter(Order = 8)]
        public long TotalAmount { get; set; }
        [MTParameter(Order = 9)]
        public string CredentialsTitle { get; set; }
        [MTParameter(Order = 10)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
