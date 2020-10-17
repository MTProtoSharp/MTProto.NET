using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x5a686d7c)]
    public class TLChatInviteAlready : TLAbsChatInvite
    {
        public override uint Constructor
        {
            get
            {
                return 0x5a686d7c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChat Chat { get; set; }


    }
}
