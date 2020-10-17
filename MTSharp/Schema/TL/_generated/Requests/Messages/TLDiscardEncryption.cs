using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xedd923c5)]
    public class TLDiscardEncryption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xedd923c5;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
