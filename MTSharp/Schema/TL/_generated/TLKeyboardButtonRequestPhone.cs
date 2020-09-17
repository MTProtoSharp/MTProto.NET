using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb16a6c29)]
    public class TLKeyboardButtonRequestPhone : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xb16a6c29;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
