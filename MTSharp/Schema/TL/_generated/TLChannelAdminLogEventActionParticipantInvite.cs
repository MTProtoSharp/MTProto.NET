using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe31c34d8)]
    public class TLChannelAdminLogEventActionParticipantInvite : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe31c34d8;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChannelParticipant Participant { get; set; }


    }
}
