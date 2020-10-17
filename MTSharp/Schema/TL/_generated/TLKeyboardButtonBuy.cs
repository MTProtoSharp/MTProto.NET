using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xafd93fbb)]
    public class TLKeyboardButtonBuy : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xafd93fbb;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
