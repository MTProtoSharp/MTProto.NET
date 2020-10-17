using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbad0e5bb)]
    public class TLPeerChat : TLAbsPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xbad0e5bb;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
