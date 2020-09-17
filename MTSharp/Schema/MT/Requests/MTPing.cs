using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0x7abe77ec)]
    public class MTPing : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7abe77ec;
            }
        }

        [MTParameter(Order = 0)]
        public long PingId { get; set; }


    }
}
