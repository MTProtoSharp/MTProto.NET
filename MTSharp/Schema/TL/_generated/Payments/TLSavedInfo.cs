using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0xfb8fe43c)]
    public class TLSavedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfb8fe43c;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool HasSavedCredentials { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPaymentRequestedInfo SavedInfo { get; set; }


    }
}
