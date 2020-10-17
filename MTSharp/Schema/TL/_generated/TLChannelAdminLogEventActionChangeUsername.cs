using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6a4afc38)]
    public class TLChannelAdminLogEventActionChangeUsername : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x6a4afc38;
            }
        }

        [MTParameter(Order = 0)]
        public string PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public string NewValue { get; set; }


    }
}
