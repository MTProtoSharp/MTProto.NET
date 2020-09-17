using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x40771900)]
    public class TLUpdateChannelWebPage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x40771900;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsWebPage Webpage { get; set; }
        [MTParameter(Order = 2)]
        public int Pts { get; set; }
        [MTParameter(Order = 3)]
        public int PtsCount { get; set; }


    }
}
