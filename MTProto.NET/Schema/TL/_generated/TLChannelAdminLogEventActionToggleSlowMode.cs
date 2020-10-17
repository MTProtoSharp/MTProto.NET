using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x53909779)]
    public class TLChannelAdminLogEventActionToggleSlowMode : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x53909779;
            }
        }

        [MTParameter(Order = 0)]
        public int PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public int NewValue { get; set; }


    }
}
