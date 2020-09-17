using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x861cc8a0)]
    public class TLInputStickerSetShortName : TLAbsInputStickerSet
    {
        public override uint Constructor
        {
            get
            {
                return 0x861cc8a0;
            }
        }

        [MTParameter(Order = 0)]
        public string ShortName { get; set; }


    }
}
