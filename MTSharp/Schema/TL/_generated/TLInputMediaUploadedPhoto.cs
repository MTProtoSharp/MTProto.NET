using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1e287d04)]
    public class TLInputMediaUploadedPhoto : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e287d04;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsInputDocument> Stickers { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
