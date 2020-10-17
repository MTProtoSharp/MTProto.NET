using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xdef60797)]
    public class TLEditChatAbout : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdef60797;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public string About { get; set; }


    }
}
