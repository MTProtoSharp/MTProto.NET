using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x546dd7a6)]
    public class TLGetParticipant : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x546dd7a6;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }


    }
}
