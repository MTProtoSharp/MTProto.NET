using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x947ca848)]
    public class TLBotResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x947ca848;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Gallery { get; set; }
        [MTParameter(Order = 2)]
        public long QueryId { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public string NextOffset { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLInlineBotSwitchPM SwitchPm { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsBotInlineResult> Results { get; set; }
        [MTParameter(Order = 6)]
        public int CacheTime { get; set; }
        [MTParameter(Order = 7)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
