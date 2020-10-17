using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0xbf9459b7)]
    public class TLInvokeWithoutUpdates : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf9459b7;
            }
        }

        [MTParameter(Order = 0)]
        public MTObject Query { get; set; }


    }
}
