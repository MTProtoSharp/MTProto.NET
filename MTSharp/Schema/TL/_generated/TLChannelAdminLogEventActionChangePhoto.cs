using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x434bd2af)]
    public class TLChannelAdminLogEventActionChangePhoto : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x434bd2af;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPhoto PrevPhoto { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsPhoto NewPhoto { get; set; }


    }
}
