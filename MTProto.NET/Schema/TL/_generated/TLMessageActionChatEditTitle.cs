using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb5a1ce5a)]
    public class TLMessageActionChatEditTitle : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb5a1ce5a;
            }
        }

        [MTParameter(Order = 0)]
        public string Title { get; set; }


    }
}
