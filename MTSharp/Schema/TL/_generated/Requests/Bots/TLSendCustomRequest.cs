using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Bots
{
    [MTObject(0xaa2769ed)]
    public class TLSendCustomRequest : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa2769ed;
            }
        }

        [MTParameter(Order = 0)]
        public string CustomMethod { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLDataJSON Params { get; set; }


    }
}
