using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x55188a2e)]
    public class TLChannelAdminLogEventActionChangeAbout : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x55188a2e;
            }
        }

        [MTParameter(Order = 0)]
        public string PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public string NewValue { get; set; }


    }
}
