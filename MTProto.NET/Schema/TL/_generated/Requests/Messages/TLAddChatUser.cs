using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xf9a0aa09)]
    public class TLAddChatUser : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf9a0aa09;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 2)]
        public int FwdLimit { get; set; }


    }
}
