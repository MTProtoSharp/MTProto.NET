using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9de7a269)]
    public class TLInputStickerSetID : TLAbsInputStickerSet
    {
        public override uint Constructor
        {
            get
            {
                return 0x9de7a269;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
