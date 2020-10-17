using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x810a9fec)]
    public class TLGetBotCallbackAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x810a9fec;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Game { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 3)]
        public int MsgId { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public byte[] Data { get; set; }


    }
}
