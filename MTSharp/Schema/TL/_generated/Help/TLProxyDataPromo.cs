using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x2bf7ee23)]
    public class TLProxyDataPromo : TLAbsProxyData
    {
        public override uint Constructor
        {
            get
            {
                return 0x2bf7ee23;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
