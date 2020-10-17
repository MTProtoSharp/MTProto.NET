using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe6b76ae)]
    public class TLChannelAdminLogEventActionChangeLocation : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6b76ae;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChannelLocation PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsChannelLocation NewValue { get; set; }


    }
}
