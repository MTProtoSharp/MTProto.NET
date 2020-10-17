using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x40582bb2)]
    public class TLSetDiscussionGroup : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x40582bb2;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Broadcast { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputChannel Group { get; set; }


    }
}
