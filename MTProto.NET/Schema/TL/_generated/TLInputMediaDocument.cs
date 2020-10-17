using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputDocument Id { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
