using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbec268ef)]
    public class TLUpdateNotifySettings : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xbec268ef;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsNotifyPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }


    }
}
