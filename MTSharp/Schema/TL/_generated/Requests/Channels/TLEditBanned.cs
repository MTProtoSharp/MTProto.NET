using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x72796912)]
    public class TLEditBanned : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x72796912;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLChatBannedRights BannedRights { get; set; }


    }
}
