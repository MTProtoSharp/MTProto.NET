using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Photos
{
    [MTObject(0x89f30f69)]
    public class TLUploadProfilePhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x89f30f69;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLAbsInputFile Video { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public double? VideoStartTs { get; set; }


    }
}
