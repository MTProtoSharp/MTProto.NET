using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x98592475)]
    public class TLUpdateChannelPinnedMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x98592475;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }


    }
}
