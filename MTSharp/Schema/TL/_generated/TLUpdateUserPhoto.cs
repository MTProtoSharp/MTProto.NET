using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x95313b0c)]
    public class TLUpdateUserPhoto : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x95313b0c;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsUserProfilePhoto Photo { get; set; }
        [MTParameter(Order = 3)]
        public bool Previous { get; set; }


    }
}
