using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xaabb1763)]
    public class TLGetWallPapers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaabb1763;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
