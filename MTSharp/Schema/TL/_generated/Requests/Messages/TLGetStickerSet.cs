using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x2619a90e)]
    public class TLGetStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2619a90e;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet Stickerset { get; set; }


    }
}
