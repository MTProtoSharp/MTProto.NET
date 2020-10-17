using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1759c560)]
    public class TLPageBlockPhoto : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x1759c560;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long PhotoId { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLPageCaption Caption { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public long? WebpageId { get; set; }


    }
}
