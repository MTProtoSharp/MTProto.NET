using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7d748d04)]
    public class TLDataJSON : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7d748d04;
            }
        }

        [MTParameter(Order = 0)]
        public string Data { get; set; }


    }
}
