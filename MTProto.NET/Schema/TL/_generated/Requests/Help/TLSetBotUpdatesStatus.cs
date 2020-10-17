using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0xec22cfcd)]
    public class TLSetBotUpdatesStatus : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xec22cfcd;
            }
        }

        [MTParameter(Order = 0)]
        public int PendingUpdatesCount { get; set; }
        [MTParameter(Order = 1)]
        public string Message { get; set; }


    }
}
