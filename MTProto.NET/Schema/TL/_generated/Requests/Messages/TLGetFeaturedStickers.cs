using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x2dacca4f)]
    public class TLGetFeaturedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2dacca4f;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
