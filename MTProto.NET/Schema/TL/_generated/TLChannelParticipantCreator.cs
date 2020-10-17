using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x808d15a4)]
    public class TLChannelParticipantCreator : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0x808d15a4;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Rank { get; set; }


    }
}
