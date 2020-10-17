using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x70db6837)]
    public class TLUpdateChannelAvailableMessages : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x70db6837;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public int AvailableMinId { get; set; }


    }
}
