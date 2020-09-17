using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x5108d648)]
    public class TLFoundStickerSets : TLAbsFoundStickerSets
    {
        public override uint Constructor
        {
            get
            {
                return 0x5108d648;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }


    }
}
