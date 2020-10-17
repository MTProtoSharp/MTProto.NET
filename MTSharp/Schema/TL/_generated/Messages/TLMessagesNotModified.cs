using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x74535f21)]
    public class TLMessagesNotModified : TLAbsMessages
    {
        public override uint Constructor
        {
            get
            {
                return 0x74535f21;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }


    }
}
