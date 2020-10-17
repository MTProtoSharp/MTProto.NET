using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xd4982db5)]
    public class TLGetTopPeers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd4982db5;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Correspondents { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool BotsPm { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool BotsInline { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool PhoneCalls { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool ForwardUsers { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool ForwardChats { get; set; }
        [MTParameter(Order = 7, FlagBitId = 10, FlagType = FlagType.True)]
        public bool Groups { get; set; }
        [MTParameter(Order = 8, FlagBitId = 15, FlagType = FlagType.True)]
        public bool Channels { get; set; }
        [MTParameter(Order = 9)]
        public int Offset { get; set; }
        [MTParameter(Order = 10)]
        public int Limit { get; set; }
        [MTParameter(Order = 11)]
        public int Hash { get; set; }


    }
}
