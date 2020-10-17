using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Updates
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Final { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
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
