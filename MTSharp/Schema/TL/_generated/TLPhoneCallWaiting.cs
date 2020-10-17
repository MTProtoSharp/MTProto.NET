using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1b8f4ad1)]
    public class TLPhoneCallWaiting : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b8f4ad1;
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
        public MTSharp.Schema.TL.TLPhoneCallProtocol Protocol { get; set; }
        [MTParameter(Order = 8, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? ReceiveDate { get; set; }


    }
}
