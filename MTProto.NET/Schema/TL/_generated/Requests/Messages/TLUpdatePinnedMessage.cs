using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xd2aaf7ec)]
    public class TLUpdatePinnedMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd2aaf7ec;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Silent { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 3)]
        public int Id { get; set; }


    }
}
