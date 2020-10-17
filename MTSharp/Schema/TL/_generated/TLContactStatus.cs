using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd3680c61)]
    public class TLContactStatus : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd3680c61;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsUserStatus Status { get; set; }


    }
}
