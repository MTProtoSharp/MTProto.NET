using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Payments
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
        public TLVector<MTProto.NET.Schema.TL.TLBankCardOpenUrl> OpenUrls { get; set; }


    }
}
