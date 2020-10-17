using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7b8e7de6)]
    public class TLInputPeerUser : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x7b8e7de6;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
