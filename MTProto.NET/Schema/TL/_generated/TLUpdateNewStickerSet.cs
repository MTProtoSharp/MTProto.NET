using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x688a30aa)]
    public class TLUpdateNewStickerSet : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x688a30aa;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.Messages.TLStickerSet Stickerset { get; set; }


    }
}
