using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3c20629f)]
    public class TLInlineBotSwitchPM : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3c20629f;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }
        [MTParameter(Order = 1)]
        public string StartParam { get; set; }


    }
}
