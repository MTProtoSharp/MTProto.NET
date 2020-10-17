using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x519bc2b1)]
    public class TLUploadMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x519bc2b1;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputMedia Media { get; set; }


    }
}
