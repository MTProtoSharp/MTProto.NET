using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0x11e831ee)]
    public class TLGetInactiveChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x11e831ee;
            }
        }



    }
}
