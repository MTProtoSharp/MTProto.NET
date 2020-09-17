using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1427a5e1)]
    public class TLChannelParticipantsBanned : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0x1427a5e1;
            }
        }

        [MTParameter(Order = 0)]
        public string Q { get; set; }


    }
}
