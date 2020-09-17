using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x35e410a8)]
    public class TLStickerSetInstallResultArchive : TLAbsStickerSetInstallResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x35e410a8;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }


    }
}
