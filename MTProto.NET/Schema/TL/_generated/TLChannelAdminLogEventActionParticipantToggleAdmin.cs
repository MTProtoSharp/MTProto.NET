using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd5676710)]
    public class TLChannelAdminLogEventActionParticipantToggleAdmin : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xd5676710;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChannelParticipant PrevParticipant { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsChannelParticipant NewParticipant { get; set; }


    }
}
