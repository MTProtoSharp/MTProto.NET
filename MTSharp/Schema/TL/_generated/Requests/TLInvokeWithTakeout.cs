using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0xaca9fd2e)]
    public class TLInvokeWithTakeout : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaca9fd2e;
            }
        }

        [MTParameter(Order = 0)]
        public long TakeoutId { get; set; }
        [MTParameter(Order = 1)]
        public MTObject Query { get; set; }


    }
}
