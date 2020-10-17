using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xf05b4804)]
    public class TLInitTakeoutSession : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf05b4804;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Contacts { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool MessageUsers { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool MessageChats { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool MessageMegagroups { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool MessageChannels { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Files { get; set; }
        [MTParameter(Order = 7, FlagBitId = 5, FlagType = FlagType.Null)]
        public int? FileMaxSize { get; set; }


    }
}
