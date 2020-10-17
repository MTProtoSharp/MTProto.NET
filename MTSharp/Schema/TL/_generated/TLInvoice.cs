using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc30aa358)]
    public class TLInvoice : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc30aa358;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Test { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool NameRequested { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool PhoneRequested { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool EmailRequested { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool ShippingAddressRequested { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Flexible { get; set; }
        [MTParameter(Order = 7, FlagBitId = 6, FlagType = FlagType.True)]
        public bool PhoneToProvider { get; set; }
        [MTParameter(Order = 8, FlagBitId = 7, FlagType = FlagType.True)]
        public bool EmailToProvider { get; set; }
        [MTParameter(Order = 9)]
        public string Currency { get; set; }
        [MTParameter(Order = 10)]
        public TLVector<MTSharp.Schema.TL.TLLabeledPrice> Prices { get; set; }


    }
}
