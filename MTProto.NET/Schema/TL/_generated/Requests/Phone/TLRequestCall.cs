using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Phone
{
    [MTObject(0x42ff96ed)]
    public class TLRequestCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x42ff96ed;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Video { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 3)]
        public int RandomId { get; set; }
        [MTParameter(Order = 4)]
        public byte[] GAHash { get; set; }
        [MTParameter(Order = 5)]
        public MTProto.NET.Schema.TL.TLPhoneCallProtocol Protocol { get; set; }


    }
}
