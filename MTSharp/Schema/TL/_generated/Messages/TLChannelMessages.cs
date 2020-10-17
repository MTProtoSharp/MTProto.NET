using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x99262e37)]
    public class TLChannelMessages : TLAbsMessages
    {
        public override uint Constructor
        {
            get
            {
                return 0x99262e37;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Inexact { get; set; }
        [MTParameter(Order = 2)]
        public int Pts { get; set; }
        [MTParameter(Order = 3)]
        public int Count { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
