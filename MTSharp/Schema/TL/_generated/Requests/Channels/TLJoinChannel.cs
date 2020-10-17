using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x24b524c5)]
    public class TLJoinChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x24b524c5;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }


    }
}
