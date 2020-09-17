using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x179be863)]
    public class TLInputPeerChat : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x179be863;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
