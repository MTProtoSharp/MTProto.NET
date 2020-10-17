using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x36a73f77)]
    public class TLReadMessageContents : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x36a73f77;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Id { get; set; }


    }
}
