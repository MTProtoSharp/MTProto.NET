using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x392718f8)]
    public class TLSaveRecentSticker : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x392718f8;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Attached { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputDocument Id { get; set; }
        [MTParameter(Order = 3)]
        public bool Unsave { get; set; }


    }
}
