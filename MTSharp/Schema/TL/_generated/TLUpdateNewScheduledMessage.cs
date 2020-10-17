using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x39a51dfb)]
    public class TLUpdateNewScheduledMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x39a51dfb;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }


    }
}
