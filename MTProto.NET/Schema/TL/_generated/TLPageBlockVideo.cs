using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7c8fe7b6)]
    public class TLPageBlockVideo : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x7c8fe7b6;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Autoplay { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Loop { get; set; }
        [MTParameter(Order = 3)]
        public long VideoId { get; set; }
        [MTParameter(Order = 4)]
        public MTProto.NET.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
