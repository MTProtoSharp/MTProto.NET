using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x63c66506)]
    public class TLGetMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x63c66506;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputMessage> Id { get; set; }


    }
}
