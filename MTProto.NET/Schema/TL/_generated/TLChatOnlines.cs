using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf041e250)]
    public class TLChatOnlines : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf041e250;
            }
        }

        [MTParameter(Order = 0)]
        public int Onlines { get; set; }


    }
}
