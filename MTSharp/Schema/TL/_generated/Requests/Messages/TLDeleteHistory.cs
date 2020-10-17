using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x1c015b09)]
    public class TLDeleteHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c015b09;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool JustClear { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Revoke { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 4)]
        public int MaxId { get; set; }


    }
}
