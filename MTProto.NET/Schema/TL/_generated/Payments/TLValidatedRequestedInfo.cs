using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Payments
{
    [MTObject(0xd1451883)]
    public class TLValidatedRequestedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd1451883;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Id { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<MTProto.NET.Schema.TL.TLShippingOption> ShippingOptions { get; set; }


    }
}
