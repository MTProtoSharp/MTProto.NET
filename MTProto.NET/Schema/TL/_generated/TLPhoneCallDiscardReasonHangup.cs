using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x57adc690)]
    public class TLPhoneCallDiscardReasonHangup : TLAbsPhoneCallDiscardReason
    {
        public override uint Constructor
        {
            get
            {
                return 0x57adc690;
            }
        }



    }
}
