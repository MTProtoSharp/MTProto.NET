using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa2fa4880)]
    public class TLKeyboardButton : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xa2fa4880;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
