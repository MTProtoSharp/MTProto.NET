using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x695150d7)]
    public class TLMessageMediaPhoto : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x695150d7;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
