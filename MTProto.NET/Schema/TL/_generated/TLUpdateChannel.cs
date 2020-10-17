using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb6d45656)]
    public class TLUpdateChannel : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb6d45656;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }


    }
}
