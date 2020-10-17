using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x514e999d)]
    public class TLGetInlineBotResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x514e999d;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser Bot { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 4)]
        public string Query { get; set; }
        [MTParameter(Order = 5)]
        public string Offset { get; set; }


    }
}
