using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe0611f16)]
    public class TLDeleteChatUser : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0611f16;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }


    }
}
