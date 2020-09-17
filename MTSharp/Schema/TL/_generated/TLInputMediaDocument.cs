using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x23ab23d2)]
    public class TLInputMediaDocument : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x23ab23d2;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputDocument Id { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
