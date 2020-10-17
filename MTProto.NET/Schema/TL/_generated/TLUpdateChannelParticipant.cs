using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x65d2b464)]
    public class TLUpdateChannelParticipant : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x65d2b464;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }
        [MTParameter(Order = 3)]
        public int UserId { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsChannelParticipant PrevParticipant { get; set; }
        [MTParameter(Order = 5, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLAbsChannelParticipant NewParticipant { get; set; }
        [MTParameter(Order = 6)]
        public int Qts { get; set; }


    }
}
