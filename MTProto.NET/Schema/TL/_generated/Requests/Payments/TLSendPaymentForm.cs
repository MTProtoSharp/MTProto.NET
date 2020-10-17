using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Payments
{
    [MTObject(0x2b8879b3)]
    public class TLSendPaymentForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2b8879b3;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public string RequestedInfoId { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public string ShippingOptionId { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsInputPaymentCredentials Credentials { get; set; }


    }
}
