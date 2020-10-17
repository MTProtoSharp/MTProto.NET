using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x69d3ab26)]
    public class TLUserProfilePhoto : TLAbsUserProfilePhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x69d3ab26;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool HasVideo { get; set; }
        [MTParameter(Order = 2)]
        public long PhotoId { get; set; }
        [MTParameter(Order = 3)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoSmall { get; set; }
        [MTParameter(Order = 4)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoBig { get; set; }
        [MTParameter(Order = 5)]
        public int DcId { get; set; }


    }
}
