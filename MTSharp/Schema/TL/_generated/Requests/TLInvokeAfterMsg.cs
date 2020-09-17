using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0xcb9f372d)]
    public class TLInvokeAfterMsg : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcb9f372d;
            }
        }

        [MTParameter(Order = 0)]
        public long MsgId { get; set; }
        [MTParameter(Order = 1)]
        public MTObject Query { get; set; }


    }
}
