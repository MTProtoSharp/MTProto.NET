using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x0949d9dc)]
    public class MTFutureSalt : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x0949d9dc;
            }
        }

        [MTParameter(Order = 0)]
        public int ValidSince { get; set; }
        [MTParameter(Order = 1)]
        public int ValidUntil { get; set; }
        [MTParameter(Order = 2)]
        public long Salt { get; set; }


    }
}
