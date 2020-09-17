using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9db1bc6d)]
    public class TLPeerUser : TLAbsPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x9db1bc6d;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }


    }
}
