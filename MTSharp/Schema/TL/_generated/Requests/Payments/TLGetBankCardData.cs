using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Payments
{
    [MTObject(0x2e79d779)]
    public class TLGetBankCardData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2e79d779;
            }
        }

        [MTParameter(Order = 0)]
        public string Number { get; set; }


    }
}
