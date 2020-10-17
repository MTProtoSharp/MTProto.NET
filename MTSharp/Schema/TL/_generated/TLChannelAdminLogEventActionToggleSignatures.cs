using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x26ae0971)]
    public class TLChannelAdminLogEventActionToggleSignatures : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x26ae0971;
            }
        }

        [MTParameter(Order = 0)]
        public bool NewValue { get; set; }


    }
}
