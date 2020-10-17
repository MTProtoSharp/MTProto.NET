using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x38641628)]
    public class TLStickerSetInstallResultSuccess : TLAbsStickerSetInstallResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x38641628;
            }
        }



    }
}
