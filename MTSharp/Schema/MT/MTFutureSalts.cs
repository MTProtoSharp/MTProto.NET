using MTSharp.Attributes;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.MT
{
    [MTObject(0xae500895)]
    public class MTFutureSalts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae500895;
            }
        }

        [MTParameter(Order = 0)]
        public long ReqMsgId { get; set; }
        [MTParameter(Order = 1)]
        public int Now { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTFutureSalt> Salts { get; set; }


    }
}
