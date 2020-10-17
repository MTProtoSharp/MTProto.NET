using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe73547e1)]
    public class TLUpdateBotCallbackQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe73547e1;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long QueryId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 4)]
        public int MsgId { get; set; }
        [MTParameter(Order = 5)]
        public long ChatInstance { get; set; }
        [MTParameter(Order = 6, FlagBitId = 0, FlagType = FlagType.Null)]
        public byte[] Data { get; set; }
        [MTParameter(Order = 7, FlagBitId = 1, FlagType = FlagType.Null)]
        public string GameShortName { get; set; }


    }
}
