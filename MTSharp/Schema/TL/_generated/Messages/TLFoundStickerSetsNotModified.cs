using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xd54b65d)]
    public class TLFoundStickerSetsNotModified : TLAbsFoundStickerSets
    {
        public override uint Constructor
        {
            get
            {
                return 0xd54b65d;
            }
        }



    }
}
