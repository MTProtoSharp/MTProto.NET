using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0xa4bcc6fe)]
    public class TLChannelDifferenceTooLong : TLAbsChannelDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0xa4bcc6fe;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Final { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Timeout { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsDialog Dialog { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
