using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0x3dc4b4f0)]
    public class TLInvokeAfterMsgs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3dc4b4f0;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> MsgIds { get; set; }
        [MTParameter(Order = 1)]
        public MTObject Query { get; set; }


    }
}
