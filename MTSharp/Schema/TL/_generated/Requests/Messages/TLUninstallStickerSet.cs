using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xf96e55de)]
    public class TLUninstallStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf96e55de;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet Stickerset { get; set; }


    }
}
