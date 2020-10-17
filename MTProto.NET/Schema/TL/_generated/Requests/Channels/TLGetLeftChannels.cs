using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0x8341ecc0)]
    public class TLGetLeftChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8341ecc0;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }


    }
}
