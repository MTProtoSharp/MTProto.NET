using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb4c83b4c)]
    public class TLNotifyUsers : TLAbsNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4c83b4c;
            }
        }



    }
}
