using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x3b831c66)]
    public class TLGetFullChat : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3b831c66;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
