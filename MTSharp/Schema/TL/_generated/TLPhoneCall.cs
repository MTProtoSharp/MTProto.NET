using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8742ae7f)]
    public class TLPhoneCall : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x8742ae7f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 5, FlagType = FlagType.True)]
        public bool P2pAllowed { get; set; }
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
        public byte[] GAOrB { get; set; }
        [MTParameter(Order = 8)]
        public long KeyFingerprint { get; set; }
        [MTParameter(Order = 9)]
        public MTSharp.Schema.TL.TLPhoneCallProtocol Protocol { get; set; }
        [MTParameter(Order = 10)]
        public TLVector<MTSharp.Schema.TL.TLPhoneConnection> Connections { get; set; }
        [MTParameter(Order = 11)]
        public int StartDate { get; set; }


    }
}
