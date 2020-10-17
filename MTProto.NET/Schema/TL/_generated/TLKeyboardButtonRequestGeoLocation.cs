using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfc796b3f)]
    public class TLKeyboardButtonRequestGeoLocation : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc796b3f;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
