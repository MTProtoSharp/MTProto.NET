using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Payments
{
    [MTObject(0x770a8e74)]
    public class TLValidateRequestedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x770a8e74;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Save { get; set; }
        [MTParameter(Order = 2)]
        public int MsgId { get; set; }
        [MTParameter(Order = 3)]
        public MTProto.NET.Schema.TL.TLPaymentRequestedInfo Info { get; set; }


    }
}
