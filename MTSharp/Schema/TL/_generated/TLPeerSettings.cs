using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x733f2961)]
    public class TLPeerSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x733f2961;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool ReportSpam { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool AddContact { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool BlockContact { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool ShareContact { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool NeedContactsException { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool ReportGeo { get; set; }
        [MTParameter(Order = 7, FlagBitId = 7, FlagType = FlagType.True)]
        public bool Autoarchived { get; set; }
        [MTParameter(Order = 8, FlagBitId = 6, FlagType = FlagType.Null)]
        public int? GeoDistance { get; set; }


    }
}
