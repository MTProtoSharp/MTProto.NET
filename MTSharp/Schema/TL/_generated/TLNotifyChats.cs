using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc007cec3)]
    public class TLNotifyChats : TLAbsNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xc007cec3;
            }
        }



    }
}
