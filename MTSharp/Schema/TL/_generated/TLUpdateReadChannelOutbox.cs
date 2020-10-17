using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x25d6c9c7)]
    public class TLUpdateReadChannelOutbox : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x25d6c9c7;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }


    }
}
