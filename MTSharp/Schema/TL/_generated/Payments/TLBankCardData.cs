using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0x3e24e573)]
    public class TLBankCardData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3e24e573;
            }
        }

        [MTParameter(Order = 0)]
        public string Title { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTSharp.Schema.TL.TLBankCardOpenUrl> OpenUrls { get; set; }


    }
}
