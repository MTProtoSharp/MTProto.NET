using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xb86e380e)]
    public class TLGetPollVotes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb86e380e;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 2)]
        public int Id { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public byte[] Option { get; set; }
        [MTParameter(Order = 4, FlagBitId = 1, FlagType = FlagType.Null)]
        public string Offset { get; set; }
        [MTParameter(Order = 5)]
        public int Limit { get; set; }


    }
}
