using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
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
        public TLVector<MTProto.NET.Schema.TL.TLKeyboardButtonRow> Rows { get; set; }


    }
}
