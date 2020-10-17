using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfc878fc8)]
    public class TLPhoneCallProtocol : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc878fc8;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool UdpP2p { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool UdpReflector { get; set; }
        [MTParameter(Order = 3)]
        public int MinLayer { get; set; }
        [MTParameter(Order = 4)]
        public int MaxLayer { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<string> LibraryVersions { get; set; }


    }
}
