using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Stats
{
    [MTObject(0xbdf78394)]
    public class TLBroadcastStats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbdf78394;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLStatsDateRangeDays Period { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLStatsAbsValueAndPrev Followers { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLStatsAbsValueAndPrev ViewsPerPost { get; set; }
        [MTParameter(Order = 3)]
        public MTProto.NET.Schema.TL.TLStatsAbsValueAndPrev SharesPerPost { get; set; }
        [MTParameter(Order = 4)]
        public MTProto.NET.Schema.TL.TLStatsPercentValue EnabledNotifications { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsStatsGraph GrowthGraph { get; set; }
        [MTParameter(Order = 6)]
        public TLAbsStatsGraph FollowersGraph { get; set; }
        [MTParameter(Order = 7)]
        public TLAbsStatsGraph MuteGraph { get; set; }
        [MTParameter(Order = 8)]
        public TLAbsStatsGraph TopHoursGraph { get; set; }
        [MTParameter(Order = 9)]
        public TLAbsStatsGraph InteractionsGraph { get; set; }
        [MTParameter(Order = 10)]
        public TLAbsStatsGraph IvInteractionsGraph { get; set; }
        [MTParameter(Order = 11)]
        public TLAbsStatsGraph ViewsBySourceGraph { get; set; }
        [MTParameter(Order = 12)]
        public TLAbsStatsGraph NewFollowersBySourceGraph { get; set; }
        [MTParameter(Order = 13)]
        public TLAbsStatsGraph LanguagesGraph { get; set; }
        [MTParameter(Order = 14)]
        public TLVector<MTProto.NET.Schema.TL.TLMessageInteractionCounters> RecentMessageInteractions { get; set; }


    }
}
