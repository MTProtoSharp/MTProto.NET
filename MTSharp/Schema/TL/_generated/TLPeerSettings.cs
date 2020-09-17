using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x818426cd)]
    public class TLPeerSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x818426cd;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool ReportSpam { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool AddContact { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool BlockContact { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
        public bool ShareContact { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.True)]
        public bool NeedContactsException { get; set; }
        [MTParameter(Order = 6, FromFlag = 5, FlagType = FlagType.True)]
        public bool ReportGeo { get; set; }


    }
}
