using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8f079643)]
    public class TLChannelAdminLogEventActionStopPoll : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x8f079643;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }


    }
}
