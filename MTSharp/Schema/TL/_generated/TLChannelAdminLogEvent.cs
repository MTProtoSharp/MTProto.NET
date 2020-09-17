using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3b5a3e40)]
    public class TLChannelAdminLogEvent : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3b5a3e40;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsChannelAdminLogEventAction Action { get; set; }


    }
}
