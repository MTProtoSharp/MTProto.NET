using MTSharp.Attributes;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.MT
{
    [MTObject(0x73f1f8dc)]
    public class MTMsgContainer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x73f1f8dc;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLMessage> Messages { get; set; }


    }
}
