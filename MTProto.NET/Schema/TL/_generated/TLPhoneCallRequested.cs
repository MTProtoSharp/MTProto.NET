using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x87eabb53)]
    public class TLPhoneCallRequested : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x87eabb53;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 6, FlagType = FlagType.True)]
        public bool Video { get; set; }
        [MTParameter(Order = 2)]
        public long Id { get; set; }
        [MTParameter(Order = 3)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 4)]
        public int Date { get; set; }
        [MTParameter(Order = 5)]
        public int AdminId { get; set; }
        [MTParameter(Order = 6)]
        public int ParticipantId { get; set; }
        [MTParameter(Order = 7)]
        public byte[] GAHash { get; set; }
        [MTParameter(Order = 8)]
        public MTProto.NET.Schema.TL.TLPhoneCallProtocol Protocol { get; set; }


    }
}
