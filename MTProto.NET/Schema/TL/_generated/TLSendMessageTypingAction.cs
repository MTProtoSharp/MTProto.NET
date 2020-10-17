using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x16bf744e)]
    public class TLSendMessageTypingAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x16bf744e;
            }
        }



    }
}
