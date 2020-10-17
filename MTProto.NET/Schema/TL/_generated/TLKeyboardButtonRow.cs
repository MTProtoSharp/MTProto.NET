using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x77608b83)]
    public class TLKeyboardButtonRow : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x77608b83;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsKeyboardButton> Buttons { get; set; }


    }
}
