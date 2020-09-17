using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc37521c9)]
    public class TLUpdateDeleteChannelMessages : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xc37521c9;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Messages { get; set; }
        [MTParameter(Order = 2)]
        public int Pts { get; set; }
        [MTParameter(Order = 3)]
        public int PtsCount { get; set; }


    }
}
