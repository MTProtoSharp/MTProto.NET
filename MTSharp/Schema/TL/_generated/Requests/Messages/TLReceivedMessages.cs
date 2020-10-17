using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x5a954c0)]
    public class TLReceivedMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5a954c0;
            }
        }

        [MTParameter(Order = 0)]
        public int MaxId { get; set; }


    }
}
