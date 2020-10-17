using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe5bbfe1a)]
    public class TLInputMediaPhotoExternal : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5bbfe1a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
