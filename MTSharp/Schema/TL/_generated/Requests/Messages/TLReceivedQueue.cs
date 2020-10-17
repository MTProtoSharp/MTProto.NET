using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x55a5bb66)]
    public class TLReceivedQueue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x55a5bb66;
            }
        }

        [MTParameter(Order = 0)]
        public int MaxQts { get; set; }


    }
}
