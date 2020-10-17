using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x31962a4c)]
    public class TLStatsGroupTopInviter : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x31962a4c;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Invitations { get; set; }


    }
}
