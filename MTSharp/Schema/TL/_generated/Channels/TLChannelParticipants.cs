using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Channels
{
    [MTObject(0xf56ee2a8)]
    public class TLChannelParticipants : TLAbsChannelParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0xf56ee2a8;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChannelParticipant> Participants { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
