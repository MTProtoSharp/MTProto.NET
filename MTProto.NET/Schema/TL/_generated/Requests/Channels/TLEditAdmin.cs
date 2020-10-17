using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xd33c8902)]
    public class TLEditAdmin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd33c8902;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLChatAdminRights AdminRights { get; set; }
        [MTParameter(Order = 3)]
        public string Rank { get; set; }


    }
}
