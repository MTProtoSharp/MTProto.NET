using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xf0189d3)]
    public class TLReadMentions : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0189d3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
