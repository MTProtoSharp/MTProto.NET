using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT.Requests
{
    [MTObject(0xf3427b8c)]
    public class MTPingDelayDisconnect : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf3427b8c;
            }
        }

        [MTParameter(Order = 0)]
        public long PingId { get; set; }
        [MTParameter(Order = 1)]
        public int DisconnectDelay { get; set; }


    }
}
