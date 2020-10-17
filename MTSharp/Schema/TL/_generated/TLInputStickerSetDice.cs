using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe67f520e)]
    public class TLInputStickerSetDice : TLAbsInputStickerSet
    {
        public override uint Constructor
        {
            get
            {
                return 0xe67f520e;
            }
        }

        [MTParameter(Order = 0)]
        public string Emoticon { get; set; }


    }
}
