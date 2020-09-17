using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xad8c9a23)]
    public class TLGetMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad8c9a23;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsInputMessage> Id { get; set; }


    }
}
