using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xc8edce1e)]
    public class TLMessagesSlice : TLAbsMessages
    {
        public override uint Constructor
        {
            get
            {
                return 0xc8edce1e;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Inexact { get; set; }
        [MTParameter(Order = 2)]
        public int Count { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public int? NextRate { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
