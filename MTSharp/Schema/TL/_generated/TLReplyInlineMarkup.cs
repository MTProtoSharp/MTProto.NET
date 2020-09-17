using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x48a30254)]
    public class TLReplyInlineMarkup : TLAbsReplyMarkup
    {
        public override uint Constructor
        {
            get
            {
                return 0x48a30254;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLKeyboardButtonRow> Rows { get; set; }


    }
}
