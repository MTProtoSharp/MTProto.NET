using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb3ba0635)]
    public class TLInputMediaPhoto : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xb3ba0635;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputPhoto Id { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
