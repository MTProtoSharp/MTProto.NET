using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd8292816)]
    public class TLInputUser : TLAbsInputUser
    {
        public override uint Constructor
        {
            get
            {
                return 0xd8292816;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
