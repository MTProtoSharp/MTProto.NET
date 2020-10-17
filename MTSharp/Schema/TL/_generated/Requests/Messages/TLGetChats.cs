using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x3c6aa187)]
    public class TLGetChats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3c6aa187;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Id { get; set; }


    }
}
