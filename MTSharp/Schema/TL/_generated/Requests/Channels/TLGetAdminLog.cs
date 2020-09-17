using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x33ddf480)]
    public class TLGetAdminLog : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x33ddf480;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 2)]
        public string Q { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChannelAdminLogEventsFilter EventsFilter { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public TLVector<TLAbsInputUser> Admins { get; set; }
        [MTParameter(Order = 5)]
        public long MaxId { get; set; }
        [MTParameter(Order = 6)]
        public long MinId { get; set; }
        [MTParameter(Order = 7)]
        public int Limit { get; set; }


    }
}
