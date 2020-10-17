using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xbd82b658)]
    public class TLReport : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbd82b658;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsReportReason Reason { get; set; }


    }
}
