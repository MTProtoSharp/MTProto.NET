using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x53577479)]
    public class TLGetNotifyExceptions : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x53577479;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool CompareSound { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsInputNotifyPeer Peer { get; set; }


    }
}
