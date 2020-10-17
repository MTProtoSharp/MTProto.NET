using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xafeb712e)]
    public class TLInputChannel : TLAbsInputChannel
    {
        public override uint Constructor
        {
            get
            {
                return 0xafeb712e;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
