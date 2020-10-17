using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbb2d201)]
    public class TLUpdateStickerSetsOrder : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xbb2d201;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Masks { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<long> Order { get; set; }


    }
}
