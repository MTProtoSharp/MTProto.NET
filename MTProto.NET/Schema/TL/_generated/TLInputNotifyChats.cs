using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4a95e84e)]
    public class TLInputNotifyChats : TLAbsInputNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a95e84e;
            }
        }



    }
}
