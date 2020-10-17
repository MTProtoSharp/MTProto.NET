using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x40699cd0)]
    public class TLMessageActionPaymentSent : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x40699cd0;
            }
        }

        [MTParameter(Order = 0)]
        public string Currency { get; set; }
        [MTParameter(Order = 1)]
        public long TotalAmount { get; set; }


    }
}
