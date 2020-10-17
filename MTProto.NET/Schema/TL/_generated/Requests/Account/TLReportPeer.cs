using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xae189d5f)]
    public class TLReportPeer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae189d5f;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsReportReason Reason { get; set; }


    }
}
