using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1b7907ae)]
    public class TLChannelAdminLogEventActionToggleInvites : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b7907ae;
            }
        }

        [MTParameter(Order = 0)]
        public bool NewValue { get; set; }


    }
}
