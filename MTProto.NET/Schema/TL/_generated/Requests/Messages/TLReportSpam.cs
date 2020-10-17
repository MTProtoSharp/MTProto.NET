using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xcf1592db)]
    public class TLReportSpam : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcf1592db;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
