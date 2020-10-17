using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1bfbd823)]
    public class TLUpdateUserStatus : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x1bfbd823;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsUserStatus Status { get; set; }


    }
}
