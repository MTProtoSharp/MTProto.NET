using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x683a5e46)]
    public class TLKeyboardButtonCallback : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x683a5e46;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Data { get; set; }


    }
}
