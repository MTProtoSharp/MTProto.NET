using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xb17f890)]
    public class TLRecentStickersNotModified : TLAbsRecentStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xb17f890;
            }
        }



    }
}
