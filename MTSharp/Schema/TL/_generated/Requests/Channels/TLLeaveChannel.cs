using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xf836aa95)]
    public class TLLeaveChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf836aa95;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }


    }
}
