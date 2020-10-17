using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Updates
{
    [MTObject(0x3173d78)]
    public class TLGetChannelDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3173d78;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Force { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsChannelMessagesFilter Filter { get; set; }
        [MTParameter(Order = 4)]
        public int Pts { get; set; }
        [MTParameter(Order = 5)]
        public int Limit { get; set; }


    }
}
