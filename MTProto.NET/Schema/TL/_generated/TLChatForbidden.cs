using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7328bdb)]
    public class TLChatForbidden : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x7328bdb;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }


    }
}
