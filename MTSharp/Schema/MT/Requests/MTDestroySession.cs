using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0xe7512126)]
    public class MTDestroySession : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe7512126;
            }
        }

        [MTParameter(Order = 0)]
        public long SessionId { get; set; }


    }
}
