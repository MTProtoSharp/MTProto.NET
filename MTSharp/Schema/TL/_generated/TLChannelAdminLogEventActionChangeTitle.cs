using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe6dfb825)]
    public class TLChannelAdminLogEventActionChangeTitle : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6dfb825;
            }
        }

        [MTParameter(Order = 0)]
        public string PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public string NewValue { get; set; }


    }
}
