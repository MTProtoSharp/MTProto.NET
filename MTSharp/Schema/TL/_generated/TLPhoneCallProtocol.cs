using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa2bb35cb)]
    public class TLPhoneCallProtocol : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa2bb35cb;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool UdpP2p { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool UdpReflector { get; set; }
        [MTParameter(Order = 3)]
        public int MinLayer { get; set; }
        [MTParameter(Order = 4)]
        public int MaxLayer { get; set; }


    }
}
