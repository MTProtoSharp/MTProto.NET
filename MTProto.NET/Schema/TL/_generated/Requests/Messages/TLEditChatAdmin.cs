using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xa9e69f2e)]
    public class TLEditChatAdmin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa9e69f2e;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 2)]
        public bool IsAdmin { get; set; }


    }
}
