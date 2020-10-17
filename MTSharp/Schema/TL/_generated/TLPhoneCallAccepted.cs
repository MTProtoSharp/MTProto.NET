using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x997c454a)]
    public class TLPhoneCallAccepted : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x997c454a;
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
        public byte[] GB { get; set; }
        [MTParameter(Order = 8)]
        public MTSharp.Schema.TL.TLPhoneCallProtocol Protocol { get; set; }


    }
}
