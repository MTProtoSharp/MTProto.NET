using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Bots
{
    [MTObject(0xe6213f4d)]
    public class TLAnswerWebhookJSONQuery : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6213f4d;
            }
        }

        [MTParameter(Order = 0)]
        public long QueryId { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLDataJSON Data { get; set; }


    }
}
