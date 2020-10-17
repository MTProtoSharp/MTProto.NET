using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb6213cdf)]
    public class TLShippingOption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb6213cdf;
            }
        }

        [MTParameter(Order = 0)]
        public string Id { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTProto.NET.Schema.TL.TLLabeledPrice> Prices { get; set; }


    }
}
