using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xf1749a22)]
    public class TLStickersNotModified : TLAbsStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xf1749a22;
            }
        }



    }
}
