using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x89893b45)]
    public class TLUpdateChannelReadMessagesContents : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x89893b45;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Messages { get; set; }


    }
}
