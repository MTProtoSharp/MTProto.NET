using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Updates
{
    [MTObject(0x2064674e)]
    public class TLChannelDifference : TLAbsChannelDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x2064674e;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Final { get; set; }
        [MTParameter(Order = 2)]
        public int Pts { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? Timeout { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessage> NewMessages { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsUpdate> OtherUpdates { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 7)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
