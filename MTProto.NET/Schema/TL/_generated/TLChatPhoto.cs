using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd20b9f3c)]
    public class TLChatPhoto : TLAbsChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0xd20b9f3c;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool HasVideo { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLFileLocationToBeDeprecated PhotoSmall { get; set; }
        [MTParameter(Order = 3)]
        public MTProto.NET.Schema.TL.TLFileLocationToBeDeprecated PhotoBig { get; set; }
        [MTParameter(Order = 4)]
        public int DcId { get; set; }


    }
}
