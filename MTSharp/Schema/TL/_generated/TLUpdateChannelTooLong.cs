using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xeb0467fb)]
    public class TLUpdateChannelTooLong : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb0467fb;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public int? Pts { get; set; }


    }
}
