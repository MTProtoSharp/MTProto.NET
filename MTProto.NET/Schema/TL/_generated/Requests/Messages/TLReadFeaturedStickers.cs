using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x5b118126)]
    public class TLReadFeaturedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5b118126;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> Id { get; set; }


    }
}
