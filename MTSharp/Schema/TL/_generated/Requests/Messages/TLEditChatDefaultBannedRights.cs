using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xa5866b41)]
    public class TLEditChatDefaultBannedRights : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa5866b41;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLChatBannedRights BannedRights { get; set; }


    }
}
