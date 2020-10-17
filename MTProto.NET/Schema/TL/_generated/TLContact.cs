using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf911c994)]
    public class TLContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf911c994;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public bool Mutual { get; set; }


    }
}
