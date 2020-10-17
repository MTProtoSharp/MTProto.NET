using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe6d83d7e)]
    public class TLChannelAdminLogEventActionParticipantToggleBan : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6d83d7e;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChannelParticipant PrevParticipant { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsChannelParticipant NewParticipant { get; set; }


    }
}
