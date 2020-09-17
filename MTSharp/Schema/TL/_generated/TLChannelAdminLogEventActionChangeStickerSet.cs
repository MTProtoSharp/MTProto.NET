using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb1c3caa7)]
    public class TLChannelAdminLogEventActionChangeStickerSet : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb1c3caa7;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickerSet PrevStickerset { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputStickerSet NewStickerset { get; set; }


    }
}
