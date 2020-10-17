using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
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
