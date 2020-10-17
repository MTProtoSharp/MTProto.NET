using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x258aff05)]
    public class TLKeyboardButtonUrl : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x258aff05;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }


    }
}
