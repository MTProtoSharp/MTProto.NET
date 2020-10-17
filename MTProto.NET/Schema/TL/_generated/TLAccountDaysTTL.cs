using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb8d0afdf)]
    public class TLAccountDaysTTL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb8d0afdf;
            }
        }

        [MTParameter(Order = 0)]
        public int Days { get; set; }


    }
}
