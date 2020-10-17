using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x85e42301)]
    public class TLPhoneCallDiscardReasonMissed : TLAbsPhoneCallDiscardReason
    {
        public override uint Constructor
        {
            get
            {
                return 0x85e42301;
            }
        }



    }
}
