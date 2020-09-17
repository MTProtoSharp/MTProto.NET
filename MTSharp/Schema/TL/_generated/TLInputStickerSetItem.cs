using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xffa0a496)]
    public class TLInputStickerSetItem : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xffa0a496;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputDocument Document { get; set; }
        [MTParameter(Order = 2)]
        public string Emoji { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLMaskCoords MaskCoords { get; set; }


    }
}