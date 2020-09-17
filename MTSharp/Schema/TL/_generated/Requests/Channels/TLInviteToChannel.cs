using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x199f3a6c)]
    public class TLInviteToChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x199f3a6c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsInputUser> Users { get; set; }


    }
}
