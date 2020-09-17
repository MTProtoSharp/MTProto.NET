using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2df5fc0a)]
    public class TLChannelAdminLogEventActionDefaultBannedRights : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x2df5fc0a;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLChatBannedRights PrevBannedRights { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLChatBannedRights NewBannedRights { get; set; }


    }
}
