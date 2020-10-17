using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x289da732)]
    public class TLChannelForbidden : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x289da732;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Broadcast { get; set; }
        [MTParameter(Order = 2, FlagBitId = 8, FlagType = FlagType.True)]
        public bool Megagroup { get; set; }
        [MTParameter(Order = 3)]
        public int Id { get; set; }
        [MTParameter(Order = 4)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 5)]
        public string Title { get; set; }
        [MTParameter(Order = 6, FlagBitId = 16, FlagType = FlagType.Null)]
        public int? UntilDate { get; set; }


    }
}
