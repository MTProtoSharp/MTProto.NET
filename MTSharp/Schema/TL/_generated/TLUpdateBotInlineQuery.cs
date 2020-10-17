using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x54826690)]
    public class TLUpdateBotInlineQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x54826690;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long QueryId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }
        [MTParameter(Order = 3)]
        public string Query { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsGeoPoint Geo { get; set; }
        [MTParameter(Order = 5)]
        public string Offset { get; set; }


    }
}
