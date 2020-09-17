using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0x9299359f)]
    public class MTHttpWait : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9299359f;
            }
        }

        [MTParameter(Order = 0)]
        public int MaxDelay { get; set; }
        [MTParameter(Order = 1)]
        public int WaitAfter { get; set; }
        [MTParameter(Order = 2)]
        public int MaxWait { get; set; }


    }
}
